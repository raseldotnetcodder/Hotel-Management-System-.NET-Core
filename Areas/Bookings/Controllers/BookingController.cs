using HotelApplication.Data;
using HotelApplication.Models;
using HotelApplication.Services.Interface;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelApplication.Areas.Bookings.Controllers
{
    [Area("Bookings")]
    public class BookingController : Controller
    {
        private readonly IRoomInformation<Booking> service;
        private readonly HotelDBContext context;
        private readonly IHostingEnvironment hostingEnvironment;

        public BookingController(HotelDBContext context,
            IRoomInformation<Booking> service,
            IHostingEnvironment hostingEnvironment)
        {
            this.context = context;
            this.service = service;
            this.hostingEnvironment = hostingEnvironment;
        }

        public async Task<IActionResult> Index()
        {
            var data = service.GetAllRoomsAndRoomTypes();
            return View(data);
        }

        public async Task<IActionResult> Save(int id)
        {
            Booking booking = new Booking();
            booking.Room = context.Rooms.Where(x => x.Id == id).FirstOrDefault();
            booking.RoomNo = booking.Room.RoomNumber;
            booking.RoomId = booking.Room.Id;

            ViewData["ApplicationUserId"] = new SelectList(context.Users, "Id", "Id", booking.ApplicationUserId);
            return View(booking);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Save(Booking model)
        {
            if (ModelState.IsValid)
            {
                if (model.BookingId == 0)
                {
                    await service.Post(model);
                }
                else
                {
                    await service.Edit(model);
                }
                return RedirectToAction(nameof(BookingList));
            }
            return View(model);
        }

        public async Task<IActionResult> Edit(int id)
        {
            Booking booking = new Booking();
            if (id != 0)
            {
                booking = await service.Details(id);
                return View(booking);
            }
            ViewData["ApplicationUserId"] = new SelectList(context.Users, "Id", "Id", booking.ApplicationUserId);
            return View(booking);
        }

        public async Task<IActionResult> BookingList()
        {
            Booking data = new Booking
            {
                Bookings = await service.Get()
            };
            return View(data);
        }

        public async Task<IActionResult> Details(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }
            var booking = await service.Details(id);
            if (booking == null)
            {
                return NotFound();
            }
            booking.Room = context.Rooms.Where(x => x.Id == booking.RoomId).FirstOrDefault();
            booking.Room.RoomType = context.RoomTypes.Where(x => x.Id == booking.Room.RoomTypeId).FirstOrDefault();
            var ImagesAndFeatures = await service.GetRoomFeaturesAndImages(booking.Room);
            ViewData["Features"] = ImagesAndFeatures.Features;
            ViewData["Images"] = ImagesAndFeatures.Images;
            return View(booking);
        }

        public async Task<IActionResult> Delete(int id)
        {
            var data = await context.Bookings.FindAsync(id);
            await service.Delete(data);
            return RedirectToAction(nameof(BookingList));
        }
    }
}
