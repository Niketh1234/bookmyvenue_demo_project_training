namespace BookMyVenueApi.Models
{
    public class Provider
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public ICollection<Venue> Venues { get; set; }

    }
}
