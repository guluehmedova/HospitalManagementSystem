using System.ComponentModel.DataAnnotations;

namespace HospitalMS.ViewModels
{
    public class MemberRegisterViewModel
    {
        [Required]
        [StringLength(maximumLength: 50)]
        public string FullName { get; set; }
        [Required]
        [StringLength(maximumLength: 20)]
        public string UserName { get; set; }
        [Required]
        [StringLength(maximumLength: 100)]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [StringLength(maximumLength: 25, MinimumLength = 8)]
        public string Password { get; set; }
        [Required]
        [DataType(DataType.Password), Compare(nameof(Password))]
        [StringLength(maximumLength: 25, MinimumLength = 8)]
        public string RepeatPassword { get; set; }
    }
}
