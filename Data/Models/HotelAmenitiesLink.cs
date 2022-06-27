﻿using System.ComponentModel.DataAnnotations.Schema;

namespace Sumera_Travel.Data.Models
{
    public class HotelAmenitiesLink
    {
        public int Id { get; set; }
        public int HotelRefId { get; set; }
        [ForeignKey(nameof(HotelRefId))]
        public Hotel? HotelRef { get; set; } 
        public int AmenitiesRefId { get; set; }
        [ForeignKey(nameof(AmenitiesRefId))]
        public Amenities? AmenitiesRef { get; set; }
    }
}
