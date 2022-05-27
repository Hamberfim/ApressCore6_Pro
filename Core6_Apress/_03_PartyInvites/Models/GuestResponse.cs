

namespace _03_PartyInvites.Models
{
    public class GuestResponse
    {
        // '?' - nullable type
        public string? Name { get; set; }

        public string? Email { get; set; }

        public string? Phone { get; set; }

        public bool? WillAttend { get; set; }

    }
}
