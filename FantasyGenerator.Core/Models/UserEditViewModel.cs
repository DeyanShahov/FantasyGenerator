using System.ComponentModel.DataAnnotations;

namespace FantasyGenerator.Core.Models
{
    public class UserEditViewModel
    {
        public string Id { get; set; }

        [Required]
        [Display(Name = "Poshta")]
        public string Email { get; set; }

        [Display(Name = "Telefoneca")]
        public string? PhoneNumber { get; set; }
    }
}
