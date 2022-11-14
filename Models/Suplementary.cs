using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HotelApplication.Models
{
    public class Suplementary
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Amount { get; set; }

        [Display(Name = "Total Amount")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal TotalAmount { get; set; }
        public virtual ICollection<BookingSuplementary> Bookings { get; set; }

        [NotMapped]
        public virtual IEnumerable<Suplementary> Suplementaries { get; set; }
    }
}
