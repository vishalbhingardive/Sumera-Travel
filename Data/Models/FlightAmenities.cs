using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Sumera_Travel.Data.Models
{
    public class FlightAmenities
    {
        public int Id { get; set; }

        [Unicode(false)]
        [StringLength(50)]
        public string Name { get; set; } = null!;

        [Unicode(false)]
        [StringLength(200)]
        public string? Description { get; set; }
    }
}
