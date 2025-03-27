using System.ComponentModel.DataAnnotations;

namespace Application.CQRS.Identity.Password
{
    public class ResetPasswordRequest
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string CurrentPassword { get; set; }
        [Required]
        public string NewPassword { get; set; }
        [Required]
        [Compare(nameof(NewPassword))]
        public string ConfirmedNewPassword { get; set; }
        [Required]
        public string? Token { get; set; }
    }
}
