using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HotelApplication.Models
{
    public class Feature
    {
        public Feature()
        {
            Icon = "/images/icon/default.png";
        }

        public int Id { get; set; }

        [Display(Name = "Feature Name")]
        public string Name { get; set; }
        public string Icon { get; set; }
        public virtual ICollection<RoomFeature> Rooms { get; set; }

        [NotMapped]
        public virtual IEnumerable<Feature> Features { get; set; }
    }
}
