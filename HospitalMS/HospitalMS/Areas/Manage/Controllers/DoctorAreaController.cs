using HospitalMS.Helper;
using HospitalMS.Models;
using HospitalMS.Services;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace HospitalMS.Areas.Manage.Controllers
{
    [Area("manage")]
    public class DoctorAreaController : Controller
    {
        private readonly DataContext _context;
        private readonly IWebHostEnvironment _web;
        private readonly IEmailService _emailService;

        public DoctorAreaController(DataContext context, IWebHostEnvironment web,IEmailService emailService)
        {
            _context = context;
            _web = web;
            _emailService = emailService;
        }
        public IActionResult Index(int page = 1, bool? selected = null, string? word = null)
        {
            IQueryable<Doctor> productquery = _context.Doctors.Include(x=>x.DoctorAppointments).Where(x => x.IsDeleted == false).AsQueryable();

            if (selected == false) { productquery = productquery.Where(x => x.IsDeleted == false); }
            if (selected == true) { productquery = productquery.Where(x => x.IsDeleted == true); }
            if (word != null) { productquery = productquery.Where(x => x.Name.Contains(word)); }

            ViewBag.SelectedPage = page;

            return View(PagenatedList<Doctor>.Create(productquery, page, 10));
        }
        public IActionResult Add() { return View(); }
        [HttpPost]
        [IgnoreAntiforgeryToken]
        public IActionResult Add(Doctor doctor)
        {
            if (!ModelState.IsValid) return View() ;

            if (doctor.CardImage == null)
                ModelState.AddModelError("CardImage", "ImageFile is required");
            else if (doctor.CardImage.Length > 2097152)
                ModelState.AddModelError("CardImage", "ImageFile max size is 2MB");
            else if (doctor.CardImage.ContentType != "image/jpeg" && doctor.CardImage.ContentType != "image/png" && doctor.CardImage.ContentType != "image/webp")
                ModelState.AddModelError("CardImage", "ContentType must be image/jpeg or image/png");


            doctor.Image = FIleManager.Save(_web.WebRootPath, "uploads/doctors", doctor.CardImage);

            _context.Doctors.Add(doctor);
            _context.SaveChanges();

            return RedirectToAction("index", "doctorarea");
        }
        public IActionResult Update(int Id)
        {
            Doctor doctor = _context.Doctors.FirstOrDefault(x => x.Id == Id);

            if (doctor == null)
            {
                return NotFound();
            }

            return View(doctor);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(Doctor doctor)
        {
            Doctor existdoctor= _context.Doctors.FirstOrDefault(x => x.Id == doctor.Id);

            if (existdoctor ==  null)
            {
                return NotFound();
            }

            if (doctor.CardImage != null)
            {
                if (doctor.CardImage.Length > 2097152)
                { ModelState.AddModelError("CardImage", "CardImage max size is 2MB"); return View(existdoctor); }
                else if (doctor.CardImage.ContentType != "image/jpeg" && doctor.CardImage.ContentType != "image/png" && doctor.CardImage.ContentType != "image/webp")
                { ModelState.AddModelError("CardImage", "ContentType must be image/jpeg or image/png"); return View(existdoctor); }
            }

            if (!ModelState.IsValid) { return View(); }

            if (doctor.CardImage != null)
            {
                FIleManager.Delete(_web.WebRootPath, "uploads/doctors", existdoctor.Image);
                existdoctor.Image = FIleManager.Save(_web.WebRootPath, "uploads/doctors", doctor.CardImage);
            }

            if (doctor.Image != null)
            {
                string newfilename = FIleManager.Save(_web.WebRootPath, "uploads/doctors", doctor.CardImage);

                FIleManager.Delete(_web.WebRootPath, "uploads/doctors", existdoctor.Image);

                existdoctor.Image = newfilename;
            }

            existdoctor.Name = doctor.Name;
            existdoctor.Surname = doctor.Surname;
            existdoctor.Age = doctor.Age;
            existdoctor.Experience = doctor.Experience;
            existdoctor.Profession=doctor.Profession;

            _context.SaveChanges();

            return RedirectToAction("index", "doctorarea");
        }
        public IActionResult Delete(int Id)
        {
            Doctor doctor = _context.Doctors.FirstOrDefault(x => x.Id == Id && x.IsDeleted == false);

            if (doctor == null) { return NotFound();}

            doctor.IsDeleted = true;
            _context.SaveChanges();

            return RedirectToAction("index", "doctorarea");
        }
        public IActionResult Appointments(int doctorId)
        {
            List<DoctorAppointment> appointments = _context.DoctorAppointments.Include(x => x.Doctor).Where(x => x.DoctorId == doctorId).ToList();
            return View(appointments);
        }
        public IActionResult InfoAppointment(int id)
        {
            DoctorAppointment appointment = _context.DoctorAppointments.Include(x => x.Doctor).FirstOrDefault(x => x.Id == id);

            if (appointment == null) return NotFound();

            return View(appointment);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AcceptAppointment(int id)
        {
            DoctorAppointment appointment = _context.DoctorAppointments.FirstOrDefault(x => x.Id == id);

            if (appointment == null) return NotFound();

            AppUser appUser = _context.AppUsers.FirstOrDefault(x => x.Id == appointment.AppUserId);

            if (appUser == null) return NotFound();
            appointment.Status = true;

            _context.SaveChanges();

            _emailService.Send(appUser.Email, "Your Appointment Accepted", "Thanks");

            return RedirectToAction("index");
        }
        public IActionResult DeleteAppointment(int id)
        {
            DoctorAppointment appointment = _context.DoctorAppointments.FirstOrDefault(x => x.Id == id);

            AppUser appUser = _context.AppUsers.FirstOrDefault(x => x.Id == appointment.AppUserId);
            if (appUser == null) return NotFound();

            if (appointment == null) return NotFound();

            _context.DoctorAppointments.Remove(appointment);

            _context.SaveChanges();

            _emailService.Send(appUser.Email, "Your Appointment Didn't Accepted. Choose Another Date", "Thanks");

            return Ok();
        }
    }
}
