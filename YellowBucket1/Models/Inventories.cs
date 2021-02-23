using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace YellowBucket1.Models
{
#nullable enable
    public class Inventories
    {
        [Required]
        public int ID { get; set; }
        [Required]
        public int MoviesID { get; set; }
        [Required]
        public int KiosksID { get; set; }
        [Required]
        public int NumberDVD { get; set; }
        [Required]
        public int NumberBluRay { get; set; }

        [Required]
        public int NumberDVDRentedFrom { get; set; }
        [Required]
        public int NumberBluRayRentedFrom { get; set; }
        public DateTime? DeletedAt { get; set; }
        [Required]
        public DateTime CreatedAt { get; set; }
        [Required]
        public DateTime UpdatedAt { get; set; }

        public ICollection<Rentals>? Rentals { get; set; }
        public Movies? Movie { get; set; }


    }
#nullable disable
}
