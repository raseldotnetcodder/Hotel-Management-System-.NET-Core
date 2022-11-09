using HotelApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelApplication.Models
{
    public class BookingComplementary
    {
        public int BookingId { get; set; }
        public virtual Booking Booking { get; set; }

        public int ComplementaryId { get; set; }
        public virtual Complementary Complementary { get; set; }
    }
}
