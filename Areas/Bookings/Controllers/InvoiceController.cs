using HotelApplication.Database;
using HotelApplication.Models;
using HotelApplication.Services.Interface;
using HotelApplication.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelApplication.Areas.Bookings.Controllers
{
    [Area("Bookings")]
    public class InvoiceController : Controller
    {
        private readonly IRoomInformation<Invoice> service;
        private readonly IBooking<Invoice> bookingServices;
        private readonly HotelDBContext context;
        private decimal vat = 7.5M;

        public InvoiceController(HotelDBContext context,
            IRoomInformation<Invoice> service,
            IBooking<Invoice> bookingServices)
        {
            this.context = context;
            this.service = service;
            this.bookingServices = bookingServices;
        }

        public async Task<IActionResult> Index()
        {
            Booking data = new Booking
            {
                Bookings = await context.Bookings.ToListAsync()
            };
            return View(data);
        }

        public async Task<IActionResult> Save(int id)
        {
            Invoice data = new Invoice
            {
                Booking = await context.Bookings.FindAsync(id),
                Suplementary = bookingServices.InvoiceSuplementary(id),
                Complementary = bookingServices.InvoiceComplementary(id)
            };

            var maxInvNo = context.Invoices.AsNoTracking().Max(x => x.InvoiceNumber);
            if(maxInvNo == 0)
            {
                maxInvNo = 1000;
            }
            data.InvoiceNumber = maxInvNo + 1;

            data.BookingId = data.Booking.BookingId;
            data.Amount = data.Booking.TotalAmount;
            foreach (var item in data.Suplementary)
            {
                data.Amount += item.TotalAmount;
            }

            data.VAT = data.Amount * (vat / 100);
            data.TotalAmount = data.Amount + data.VAT;
            return View(data);
        }

        [HttpPost]
        public async Task<IActionResult> Save(Invoice model)
        {
            if (ModelState.IsValid)
            {
                if (model.Id == 0)
                {
                    await service.Post(model);
                }
                return RedirectToAction(nameof(InvoiceList));
            }
            return View(model);
        }

        public IActionResult InvoiceList()
        {
            var data = bookingServices.GetAllInvoiceAndBooking();
            return View(data);
        }

        public IActionResult PaymentMethod()
        {
            return View();
        }
    }
}
