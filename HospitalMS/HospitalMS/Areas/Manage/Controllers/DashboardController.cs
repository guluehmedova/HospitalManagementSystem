using HospitalMS.Areas.Manage.ViewModels;
using HospitalMS.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace HospitalMS.Areas.Manage.Controllers
{
    [Area("manage")]
    [Authorize(Roles = "SuperAdmin,Admin")]
    public class DashboardController : Controller
    {
        private readonly DataContext _context;

        public DashboardController(DataContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            DashboardViewModel dashboardViewModel = new DashboardViewModel
            {
                Doctors = _context.Doctors.Where(x => x.IsDeleted == false).ToList(),
                AppUsers=_context.AppUsers.Where(x=>!x.IsAdmin).ToList()
            };
            return View(dashboardViewModel);
        }
    }
}
