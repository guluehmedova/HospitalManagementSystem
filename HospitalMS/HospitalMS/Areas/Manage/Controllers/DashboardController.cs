using Microsoft.AspNetCore.Mvc;

namespace HospitalMS.Areas.Manage.Controllers
{
    public class DashboardController : Controller
    {
        [Area("manage")]
        [Route("[controller]/[action]")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
