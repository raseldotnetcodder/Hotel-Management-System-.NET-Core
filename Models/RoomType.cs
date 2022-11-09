using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HotelApplication.Models
{
    public class RoomType
    {
        public RoomType()
        {
            ImageUrl = "/images/icon/default.png";
        }

        public int Id { get; set; }

        [Display(Name = "Room Catagory")]
        public string RoomTypeName { get; set; }

        [Display(Name = "Base Price")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal BasePrice { get; set; }

        [Display(Name = "Description")]
        public string Description { get; set; }

        [Display(Name = "Image")]
        public string ImageUrl { get; set; }

        public virtual ICollection<Room> Rooms { get; set; }

        [NotMapped]
        public IEnumerable<RoomType> RoomTypes { get; set; }
    }
}
