using System.ComponentModel.DataAnnotations;

namespace _03_PartyInvites.Models
{
    public class GuestResponse
    {
        // '?' - nullable type
        [Required(ErrorMessage = "Please enter your name")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Email address is required")]
        [DataType(DataType.EmailAddress)]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Please enter your phone number")]
        [DataType(DataType.PhoneNumber)]
        public string? Phone { get; set; }

        [Required(ErrorMessage = "Please specify whether you'll attend")]
        public bool? WillAttend { get; set; }

    }
}
