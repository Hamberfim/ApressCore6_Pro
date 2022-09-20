using System.ComponentModel.DataAnnotations;

namespace PartyInvites.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage = "Please Enter your name.")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Please Enter your email address.")]
        [EmailAddress]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Please Enter your phone number.")]
        [Phone]
        public string? Phone { get; set; }

        [Required(ErrorMessage = "Please specify if you will attend or not.")]
        public bool? WillAttend { get; set; }
    }
}
