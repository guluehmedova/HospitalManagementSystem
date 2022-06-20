using Microsoft.AspNetCore.Identity;

namespace HospitalMS.Models
{
    public class AppUser: IdentityUser
    {
        public string FullName { get; set; }
        public bool IsAdmin { get; set; }
    }
}
