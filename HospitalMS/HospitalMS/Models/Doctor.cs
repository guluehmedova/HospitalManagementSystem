using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HospitalMS.Models
{
    public class Doctor: BaseEntity
    {
        [StringLength(maximumLength:20)]
        public string Name { get; set; }
        [StringLength(maximumLength: 40)]
        public string Surname { get; set; }
        [Range(24,60)]
        public int Age { get; set; }
        [StringLength(maximumLength:100)]
        public string Profession { get; set; }
        [Range(1,30)]
        public int Experience { get; set; }
        [StringLength(maximumLength: 250)]
        public string Image { get; set; }
        [NotMapped]
        public IFormFile CardImage { get; set; }
        public List<UserDoctor> UserDoctors { get; set; }
    }
}
