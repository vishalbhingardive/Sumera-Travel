using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sumera_Travel.Data.Models
{
    public class Country
    {
        public int  Id { get; set; }

        [Unicode(false)]
        [StringLength(5)]
        public string Code { get; set; } = null!;

        [Unicode(false)]
        [StringLength(50)]
        public string Name { get; set; } = null!;
    }
}
