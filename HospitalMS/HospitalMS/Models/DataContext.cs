using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HospitalMS.Models
{
    public class DataContext : IdentityDbContext
    {
        public DataContext(DbContextOptions<DataContext> options): base(options)
        {

        }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<UserDoctor>  UserDoctors { get; set; }
        public DbSet<DoctorAppointment> DoctorAppointments { get; set; }
    }
}
