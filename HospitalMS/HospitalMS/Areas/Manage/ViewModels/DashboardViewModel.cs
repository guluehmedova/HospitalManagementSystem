using HospitalMS.Models;
using System.Collections.Generic;

namespace HospitalMS.Areas.Manage.ViewModels
{
    public class DashboardViewModel
    {
        public List<Doctor> Doctors { get; set; }
        public List<AppUser> AppUsers { get; set; }
    }
}
