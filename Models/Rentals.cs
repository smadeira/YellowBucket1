using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;


namespace YellowBucket1.Models
{
#nullable enable
    public class Rentals
    {
        [Required]
        public int ID { get; set; }

        [Required]
        public int InventoriesID { get; set; }

        [Required]
        public int CustomersID { get; set; }

        [Required]
        public int RentalKiosksID { get; set; }

        [Required]
        public DateTime RentalDate { get; set; }

        public int? ReturnKiosksID { get; set; }

        public DateTime? ReturnDate { get; set; }

        
        public DateTime? DeletedAt { get; set; }
        [Required]
        public DateTime CreatedAt { get; set; }
        [Required]
        public DateTime UpdatedAt { get; set; }

        
    }
#nullable disable
}
