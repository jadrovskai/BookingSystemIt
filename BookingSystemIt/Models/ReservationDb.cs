using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BookingSystemIt.Models
{
    public class ReservationDb : DbContext
    {
        public ReservationDb() : base("name=ReservationDb")
        {
        }

        public System.Data.Entity.DbSet<BookingSystemIt.Models.Reservation> Reservations { get; set; }

        public System.Data.Entity.DbSet<BookingSystemIt.Models.City> Cities { get; set; }

        public System.Data.Entity.DbSet<BookingSystemIt.Models.Hotel> Hotels { get; set; }

    }
}