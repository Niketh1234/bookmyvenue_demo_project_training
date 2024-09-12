namespace BookMyVenueApi.Models
{
    public class VenueDTO
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }

        public int ProviderId { get; set; }
    }
}
