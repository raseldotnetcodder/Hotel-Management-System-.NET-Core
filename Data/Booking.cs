using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HotelApplication.Models
{
    public class Booking
    {
        public int BookingId { get; set; }
        public int RoomId { get; set; }
        public int RoomNo { get; set; }
        public virtual Room Room { get; set; }

        [Display(Name = "Name")]
        public string CustomerName { get; set; }

        [Display(Name = "Email")]
        public string CustomerEmail { get; set; }

        [Display(Name = "Phone")]
        public string CustomerPhone { get; set; }

        [Display(Name = "Address")]
        public string CustomerAddress { get; set; }
        public string Remarks { get; set; }

        [Display(Name = "Date Created")]
        [Column(TypeName = "datetime")]
        public DateTime DateCreated { get; set; }

        [Display(Name = "Check In")]
        [Column(TypeName = "datetime")]
        public DateTime CheckIn { get; set; }

        [Display(Name = "Check Out")]
        [Column(TypeName = "datetime")]
        public DateTime CheckOut { get; set; }
        public int Guests { get; set; }

        [Display(Name = "Total Fee")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal TotalFee { get; set; }
        public bool Paid { get; set; }
        public bool Completed { get; set; }
        public int? ApplicationUserId { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }

        [NotMapped]
        public IEnumerable<Booking> Bookings { get; set; }
    }
}
