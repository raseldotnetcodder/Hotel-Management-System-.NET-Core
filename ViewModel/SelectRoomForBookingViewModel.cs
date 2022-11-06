using HotelApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelApplication.ViewModel
{
    public class SelectRoomForBookingViewModel
    {
        public int BookingId { get; set; }
        public virtual Booking Feature { get; set; }
        public int Selected { get; set; }
    }
}
