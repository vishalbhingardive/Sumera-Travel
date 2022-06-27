using System.ComponentModel.DataAnnotations.Schema;

namespace Sumera_Travel.Data.Models
{
    public class FlightAmenitiesLink
    {
        public int Id { get; set; }
        public int FlightRefId { get; set; }
        [ForeignKey(nameof(FlightRefId))]
        public Flight? FlightRef { get; set; }   
        public int FlightAmenitiesRefId { get; set; }
        [ForeignKey(nameof(FlightAmenitiesRefId))]
        public FlightAmenities? FlightAmenities { get; set; }

    }
}
