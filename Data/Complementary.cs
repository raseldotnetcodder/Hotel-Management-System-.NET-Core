using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HotelApplication.Models
{
    public class Complementary
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }
        public virtual ICollection<BookingComplementary> Bookings { get; set; }

        [NotMapped]
        public virtual IEnumerable<Complementary> Complementaries { get; set; }
    }
}
