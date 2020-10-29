using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;


namespace YellowBucket1.Models
{
#nullable enable
    public class Wishlists
    {
        [Required]
        public int ID { get; set; }
        [Required]
        public int CustomersID { get; set; }
        [Required]
        public int MoviesID { get; set; }
        public DateTime? DeletedAt { get; set; }
        [Required]
        public DateTime CreatedAt { get; set; }
        [Required]
        public DateTime UpdatedAt { get; set; }
    }
#nullable disable
}
