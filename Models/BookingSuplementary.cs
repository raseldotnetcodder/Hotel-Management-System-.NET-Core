using HotelApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelApplication.Models
{
    public class BookingSuplementary
    {
        public int BookingId { get; set; }
        public virtual Booking Booking { get; set; }

        public int SuplementaryId { get; set; }
        public virtual Suplementary Suplementary { get; set; }
    }
}
