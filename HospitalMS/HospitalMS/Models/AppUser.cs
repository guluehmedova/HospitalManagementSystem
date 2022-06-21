using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace HospitalMS.Models
{
    public class AppUser: IdentityUser
    {
        public string FullName { get; set; }
        public bool IsAdmin { get; set; }
        public List<UserDoctor> UserDoctors { get; set; }
    }
}
