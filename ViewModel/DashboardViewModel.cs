using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelApplication.ViewModel
{
    public class DashboardViewModel
    {
        public int AvailableRooms { get; set; }
        public int BookedRooms { get; set; }
        public int TotalGuests { get; set; }

        public DashboardViewModel()
        {
            AvailableRooms = 0;
            BookedRooms = 0;
            TotalGuests = 0;
        }
    }
}
