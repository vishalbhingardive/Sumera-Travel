using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sumera_Travel.Data.Models
{
    public class Airport
    {
        public int Id { get; set; }

        [StringLength(5)]
        [Unicode(false)]
        public string Code { get; set; } = null!;
        public int CityRefId { get; set; }
        [ForeignKey(nameof(CityRefId))]
        public City? CityRef { get; set; }

        [Unicode(false)]
        [StringLength(100)]
        public string Address1 { get; set;} = null!;

        [Unicode(false)]
        [StringLength(100)]
        public string? Address2 { get; set;}

        [Unicode(false)]
        [StringLength(100)]
        public string? Address3 { get; set;}

        [Unicode(false)]
        [StringLength(10)]
        public int PinCode { get; set; }

        [Unicode(false)]
        [StringLength(15)]
        public string Telephone1 { get; set; } = null!;

        [Unicode(false)]
        [StringLength(15)]
        public string? Telephone2 { get; set;}

        [Unicode(false)]
        [StringLength(30)]
        public string Email1 { get; set;} = null!;

        [Unicode(false)]
        [StringLength(30)]
        public string? Email2 { get; set;}
    }
}
