namespace HospitalMS.Models
{
    public class UserDoctor: BaseEntity
    {
        public AppUser AppUser { get; set; }
        public Doctor Doctor { get; set; }
        public int AppUserId { get; set; }
        public int DoctorId { get; set; }
    }
}
