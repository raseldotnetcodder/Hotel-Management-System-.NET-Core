using HotelApplication.Models;
using HotelApplication.Database;
using HotelApplication.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelApp.Controllers
{
    public class DashboardController : Controller
    {
        private readonly HotelDBContext context;
        public DashboardController(HotelDBContext context)
        {
            this.context = context;
        }

        public async Task<IActionResult> Index()
        {
            DashboardViewModel dashboard = new DashboardViewModel();
            Room room = new Room
            {
                Rooms = await context.Rooms.ToListAsync()
            };
            foreach (var item in room.Rooms)
            {
                if (item.Available == true)
                {
                    dashboard.AvailableRooms += 1;
                }
                else
                {
                    dashboard.BookedRooms += 1;
                }
            }

            Booking booking = new Booking
            {
                Bookings = context.Bookings.ToList()
            };
            foreach(var item in booking.Bookings)
            {
                if(item.Guests != 0)
                {
                    dashboard.TotalGuests += item.Guests;
                }
            }

            return View(dashboard);
        }
    }
}
