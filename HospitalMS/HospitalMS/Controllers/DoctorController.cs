using HospitalMS.Models;
using HospitalMS.Services;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace HospitalMS.Controllers
{
    public class DoctorController : Controller
    {
        private readonly DataContext _context;
        private readonly IEmailService _emailService;

        public DoctorController(DataContext context, IEmailService emailService)
        {
            _context = context;
            _emailService = emailService;
        }
        public IActionResult Index(int page = 1, bool? selected = null, string? word = null)
        {
            IQueryable<Doctor> doctors = _context.Doctors.AsQueryable();

            if (selected == false) { doctors = doctors.Where(x => x.IsDeleted == false); }
            if (selected == true) { doctors = doctors.Where(x => x.IsDeleted == true); }
            if (word != null) { doctors = doctors.Where(x => x.Name.Contains(word)); }

            ViewBag.select = selected;
            ViewBag.word = word;
            ViewBag.PageSize = 2;
            ViewBag.ProductCount = doctors.Count();

            return View(PagenatedList<Doctor>.Create(doctors, page, 5));
        }   
        public IActionResult Apply(AppUser appUser)
        {
            AppUser existuser = _context.AppUsers.FirstOrDefault(x => x.Id == appUser.Id);

            if(existuser==null) { return RedirectToAction("login", "account"); }


            return View();
        }
    }
}
