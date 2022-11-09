using HotelApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelApplication.ViewModel
{
    public class SelectedSuplementaryViewModel
    {
        public int SuplementaryId { get; set; }
        public virtual Suplementary Suplementary { get; set; }
        public bool Selected { get; set; }
    }
}
