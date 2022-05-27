namespace _03_PartyInvites.Models
{
    public class Repository
    {
        // this model is used for in-memory data from the form
        private static List<GuestResponse> responses = new();

        public static IEnumerable<GuestResponse> Responses => responses;

        public static void AddResponse(GuestResponse response)
        {
            Console.WriteLine(response);
            responses.Add(response);

        }

    }
}
