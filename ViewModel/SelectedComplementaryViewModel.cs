using HotelApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelApplication.ViewModel
{
    public class SelectedComplementaryViewModel
    {

        public int ComplementaryId { get; set; }
        public virtual Complementary Complementary { get; set; }
        public bool Selected { get; set; }
    }
}
