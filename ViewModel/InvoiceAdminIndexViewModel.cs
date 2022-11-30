
using HotelApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelApplication.ViewModel
{
    public class InvoiceAdminIndexViewModel
    {
        public List<Booking> Bookings { get; set; }
        public List<Invoice> Invoices { get; set; }
    }
}
