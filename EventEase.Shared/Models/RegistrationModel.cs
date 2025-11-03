using System.ComponentModel.DataAnnotations;

namespace EventEase.Shared.Models
{
    public class RegistrationModel
    {
        public int EventId { get; set; }

        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        public string Email { get; set; } = string.Empty;

        public string Notes { get; set; } = string.Empty;
    }
}
