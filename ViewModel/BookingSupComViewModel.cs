using HotelApplication.Data;
using HotelApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelApplication.ViewModel
{
    public class BookingSupComViewModel
    {
        public List<Suplementary> Suplementaries { get; set; }
        public List<Complementary> Complementaries { get; set; }
    }
}
