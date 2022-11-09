using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelApplication.Models
{
    public class Review
    {
        public int Id { get; set; }
        public int RoomId { get; set; }
        public virtual Room Room { get; set; }
        public string ReviewerName { get; set; }
        public string ReviewerEmail { get; set; }
        public string Description { get; set; }
    }
}
