using System;
using System.ComponentModel.DataAnnotations;

namespace HospitalMS.Models
{
    public class DoctorAppointment: BaseEntity
    {
        public string AppUserId { get; set; }
        public int DoctorId { get; set; }
        [StringLength(maximumLength: 100)]
        public string Email { get; set; }
        public DateTime Time { get; set; }
        public DateTime Date { get; set; }
        [StringLength(maximumLength: 50)]
        public string FullName { get; set; }
        public bool Status { get; set; }
        public AppUser AppUser { get; set; }
        public Doctor Doctor { get; set; }
    }
}
