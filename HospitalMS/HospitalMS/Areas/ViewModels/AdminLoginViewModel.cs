using System.ComponentModel.DataAnnotations;

namespace HospitalMS.Areas.ViewModels
{
    public class AdminLoginViewModel
    {
        [Required]
        [StringLength(maximumLength: 28, MinimumLength = 3)]
        public string UserName { get; set; }
        [Required]
        [StringLength(maximumLength: 25, MinimumLength = 8)]
        public string Password { get; set; }
    }
}
