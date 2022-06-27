using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sumera_Travel.Data.Models
{
    public class Hotel
    {
        public int Id { get; set; }

        [Unicode(false)]
        [StringLength(50)]
        public string Name { get; set; } = null!;
        public int Star { get; set; }
        public int CityRefId { get; set; }
        [ForeignKey(nameof(CityRefId))]
        public City? CityRef { get; set; }
        
    }
}
