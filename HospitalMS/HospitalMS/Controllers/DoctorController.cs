using HospitalMS.Models;
using HospitalMS.Services;
using HospitalMS.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalMS.Controllers
{
    public class DoctorController : Controller
    {
        private readonly DataContext _context;
        private readonly IEmailService _emailService;
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;

        public DoctorController(DataContext context, IEmailService emailService, UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            _context = context;
            _emailService = emailService;
            _userManager = userManager;
            _signInManager = signInManager;
        }
        public IActionResult Index(int page = 1, bool? selected = null, string? word = null)
        {
            IQueryable<Doctor> doctors = _context.Doctors.Include(x=>x.DoctorAppointments).Where(x=>!x.IsDeleted).AsQueryable();

            if (selected == false) { doctors = doctors.Where(x => x.IsDeleted == false); }
            if (selected == true) { doctors = doctors.Where(x => x.IsDeleted == true); }
            if (word != null) { doctors = doctors.Where(x => x.Name.Contains(word)); }

            ViewBag.select = selected;
            ViewBag.word = word;
            ViewBag.PageSize = 2;
            ViewBag.DoctorCount = doctors.Count();


            DoctorDetailViewModel doctorDetailViewModel = new DoctorDetailViewModel
            {
                Doctors = PagenatedList<Doctor>.Create(doctors, page, 5),
                GetDoctors = _context.Doctors.Where(x=>!x.IsDeleted).ToList(),
            };

            return View(doctorDetailViewModel);
        }
        public IActionResult Detail(int Id)
        {
            Doctor doctor = _context.Doctors.Include(x => x.DoctorAppointments).FirstOrDefault(x => x.Id == Id && !x.IsDeleted);

            if (doctor == null) 
            {
                return NotFound();
            }


            DoctorDetailViewModel doctorDetailViewModel = new DoctorDetailViewModel
            {
                Doctor = doctor,
                GetDoctors = _context.Doctors.Where(x => !x.IsDeleted).ToList(),
                DoctorAppointment = new DoctorAppointment(),
                DoctorAppointments = _context.DoctorAppointments.Where(x => x.Status == true && !x.IsDeleted).ToList()
            };


            TempData["DoctorId"] = doctor.Id;


            return View(doctorDetailViewModel);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Apply(DoctorAppointment appointment)
        {
            int doctorid = Convert.ToInt32(TempData["DoctorId"]);

            Doctor doctor = await _context.Doctors.Include(x => x.DoctorAppointments).FirstOrDefaultAsync(x => x.Id == doctorid && !x.IsDeleted);

            if (doctor == null) { return NotFound(); }

            DoctorDetailViewModel doctorDetailViewModel = new DoctorDetailViewModel
            {
                Doctor = doctor,
                DoctorAppointment = appointment,
                GetDoctors=_context.Doctors.Where(x=>!x.IsDeleted).ToList()
            };

            if (!ModelState.IsValid)
            {
                return View();
            }

            if (!_context.Doctors.Any(x => x.Id == doctorid))
            {
                return View("detail", doctorDetailViewModel);
            }

            AppUser user = null;
            if (User.Identity.IsAuthenticated)
            {
                user = await _userManager.FindByNameAsync(User.Identity.Name);
            }

            if (user == null)
            {
                return View("detail", doctorDetailViewModel);
            }
            else if (user.IsAdmin == true)
            {
                await _signInManager.SignOutAsync();
            }
            else
            {
                appointment.AppUserId = user.Id;
                appointment.Email = user.Email;
                appointment.FullName = user.FullName;
            }

            appointment.Status = false;
            appointment.CreatedAt = DateTime.UtcNow.AddHours(4);
            appointment.DoctorId = doctorid;

            _context.DoctorAppointments.Add(appointment);
            _context.SaveChanges();


            return RedirectToAction("index", new { Id = doctorid });
        }
    }
}
