using System.ComponentModel.DataAnnotations;

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
    }
}
