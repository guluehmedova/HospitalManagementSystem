using HospitalMS.Models;
using Microsoft.AspNetCore.Mvc;

namespace HospitalMS.Controllers
{
    [Route("[controller]/[action]")]
    public class DoctorController : Controller
    {
        private readonly DataContext _context;
        public DoctorController(DataContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
