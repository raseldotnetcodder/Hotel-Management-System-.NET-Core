using HotelApplication.Data;
using HotelApplication.Models;
using HotelApplication.Services.Interface;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelApplication.Areas.RoomInformation.Controllers
{
    [Area("RoomInformation")]
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

        public async Task<IActionResult> Details(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }
            var booking = await service.GetRoomDetailsByID(id);
            if (booking == null)
            {
                return NotFound();
            }
            var ImagesAndFeatures = await service.GetRoomFeaturesAndImages(booking.Room);
            ViewData["Features"] = ImagesAndFeatures.Features;
            ViewData["Images"] = ImagesAndFeatures.Images;
            return View(booking);
        }

        public IActionResult Create()
        {
            ViewData["ApplicationUserId"] = new SelectList(context.Users, "Id", "Id");
            ViewData["RoomId"] = new SelectList(context.Rooms, "Id", "Id");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,RoomID,DateCreated,CheckIn,CheckOut,Guests,TotalFee,Paid,Completed,ApplicationUserId,CustomerName,CustomerEmail,CustomerPhone,CustomerAddress,CustomerCity,OtherRequests")] Booking booking)
        {
            if (ModelState.IsValid)
            {
                context.Add(booking);
                await context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ApplicationUserId"] = new SelectList(context.Users, "Id", "Id", booking.ApplicationUserId);
            ViewData["RoomID"] = new SelectList(context.Rooms, "ID", "ID", booking.RoomId);
            return View(booking);
        }

        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var booking = await context.Bookings.FindAsync(id);
            if (booking == null)
            {
                return NotFound();
            }
            ViewData["ApplicationUserId"] = new SelectList(context.Users, "Id", "Id", booking.ApplicationUserId);
            ViewData["RoomID"] = new SelectList(context.Rooms, "ID", "ID", booking.RoomId);
            return View(booking);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,RoomID,DateCreated,CheckIn,CheckOut,Guests,TotalFee,Paid,Completed,ApplicationUserId,CustomerName,CustomerEmail,CustomerPhone,CustomerAddress,CustomerCity,OtherRequests")] Booking booking)
        {
            if (id != booking.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                context.Update(booking);
                await context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ApplicationUserId"] = new SelectList(context.Users, "Id", "Id", booking.ApplicationUserId);
            ViewData["RoomID"] = new SelectList(context.Rooms, "ID", "ID", booking.RoomId);
            return View(booking);
        }

        public async Task<IActionResult> Delete(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var booking = await context.Bookings
                .Include(b => b.ApplicationUser)
                .Include(b => b.Room)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (booking == null)
            {
                return NotFound();
            }

            return View(booking);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var booking = await context.Bookings.FindAsync(id);
            context.Bookings.Remove(booking);
            await context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
