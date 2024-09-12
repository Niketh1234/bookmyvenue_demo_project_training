using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BookMyVenueApi.Models
{
    public class Venue
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public float Rating { get; set; }
        public int ProviderId { get; set; }
    }
}
