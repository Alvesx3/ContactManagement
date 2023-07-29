using System.ComponentModel.DataAnnotations;

namespace ContactManagement.Models
{
    public class Cliente
    {
        public string Id { get; set; }

        [Required(ErrorMessage = "Name is required.")]
        [StringLength(255, MinimumLength = 6, ErrorMessage = "Name must be at least 6 characters long.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Contact number is required.")]
        [RegularExpression(@"^\d{9}$", ErrorMessage = "Contact number must be 9 digits.")]
        public string ContactNumber { get; set; } = string.Empty; // Set a default value

        [Required(ErrorMessage = "Email address is required.")]
        [EmailAddress(ErrorMessage = "Invalid email address.")]
        public string Email { get; set; }
    }
}
