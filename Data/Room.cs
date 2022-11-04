using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HotelApplication.Models
{
    public class Room
    {
        public int Id { get; set; }

        [Display(Name = "Room Number")]
        public int RoomNumber { get; set; }

        [Display(Name = "Room Catagory")]
        public int RoomTypeId { get; set; }
        public virtual RoomType RoomType { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }
        public bool Available { get; set; }
        public string Description { get; set; }

        [Display(Name = "Maximum Guests")]
        public int MaximumGuests { get; set; }

        public virtual List<Image> RoomImages { get; set; }
        public virtual List<Review> Reviews { get; set; }
        public virtual List<Booking> Bookings { get; set; }
        public virtual ICollection<RoomFeature> Features { get; set; }

        [NotMapped]
        public IEnumerable<Room> Rooms { get; set; }
    }
}
