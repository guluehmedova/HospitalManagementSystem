using HospitalMS.Models;
using System.Collections.Generic;

namespace HospitalMS.ViewModels
{
    public class DoctorDetailViewModel
    {
         public PagenatedList<Doctor> Doctors { get; set; }
         public List<Doctor> GetDoctors { get; set; }
         public Doctor Doctor { get; set; }
        public List<DoctorAppointment> DoctorAppointments { get; set; }
        public DoctorAppointment DoctorAppointment { get; set; }
    }
}
