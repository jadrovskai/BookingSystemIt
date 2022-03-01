using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BookingSystemIt.Models
{
    public class Hotel
    {
        [Key]
        public int HotelId { get; set; }
        [Display(Name = "Hotel")]
        public string Name { get; set; }
        public virtual List<Reservation> Reservations { get; set; }
    }
}