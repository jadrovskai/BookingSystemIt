using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BookingSystemIt.Models
{
    public class Reservation
    {
        [Key]
        public int ReservationId { get; set; }

        public int CityId { get; set; }
        public int HotelId { get; set; }
        public int DaysOfStaying { get; set; }
        public decimal Price { get; set; }
        public string HotelUrl { get; set; }
        public virtual City City { get; set; }
        public virtual Hotel Hotel { get; set; }
    }
}