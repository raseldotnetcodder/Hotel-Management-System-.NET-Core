using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelApplication.Models
{
    public class ItemImage
    {
        public int ImageId { get; set; }
        public virtual Image Image { get; set; }
        public int ItemId { get; set; }
    }
}
