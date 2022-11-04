using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HotelApplication.Models
{
    public class Image
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Size { get; set; }
        public string ImageUrl { get; set; }
        public string FilePath { get; set; }

        [NotMapped]
        public IEnumerable<Image> Images { get; set; }
    }
}
