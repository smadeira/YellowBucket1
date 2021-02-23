using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace YellowBucket1.Models
{
#nullable enable
    public class Kiosks
    {
        [Required]
        public int ID { get; set; }


        [Required, MaxLength(128)]
        [Column(TypeName = "varchar(128)")]
        public string Location { get; set; }

        [MaxLength(128)]
        [Column(TypeName = "varchar(128)")]
        public string Address { get; set; }

        [MaxLength(128)]
        [Column(TypeName = "varchar(128)")]
        public string? Address2 { get; set; }

        [MaxLength(128)]
        [Column(TypeName = "varchar(128)")]
        public string City { get; set; }

        [MaxLength(2)]
        [Column(TypeName = "char(2)")] 
        public string State { get; set; }

        [MaxLength(128)]
        [Column(TypeName = "varchar(128)")]
        public string Zip { get; set; }
        public DateTime? DeletedAt { get; set; }
        [Required]
        public DateTime CreatedAt { get; set; }
        [Required]
        public DateTime UpdatedAt { get; set; }

        public ICollection<Rentals>? Rentals { get; set; }
        public ICollection<Inventories>? Inventories { get; set; }


    }
#nullable disable
}
