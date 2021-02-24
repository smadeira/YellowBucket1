using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace YellowBucket1.Models {
#nullable enable
    public class Customers {
        [Required]
        public int ID { get; set; }

        [MaxLength(128)]
        [Column(TypeName = "varchar(128)")]
        public string? FirstName { get; set; }

        [MaxLength(128)]
        [Column(TypeName = "varchar(128)")]
        public string? LasttName { get; set; }

        [MaxLength(128)]
        [Column(TypeName = "varchar(128)")]
        public string? Email { get; set; }

        [MaxLength(128)]
        [Column(TypeName = "varchar(128)")]
        public string? Password { get; set; }

        [MaxLength(128)]
        [Column(TypeName = "varchar(128)")]
        public string? Address { get; set; }

        [MaxLength(128)]
        [Column(TypeName = "varchar(128)")]
        public string? Address2 { get; set; }

        [MaxLength(128)]
        [Column(TypeName = "varchar(128)")]
        public string? City { get; set; }

        [MaxLength(2)]
        [Column(TypeName = "char(2)")]
        public string? State { get; set; }

        [MaxLength(16)]
        [Column(TypeName = "varchar(16)")]
        public string? Zip { get; set; }

        public DateTime? DeletedAt { get; set; }
        [Required]
        public DateTime CreatedAt { get; set; }
        [Required]
        public DateTime UpdatedAt { get; set; }

        public ICollection<Wishlists>? Wishlists { get; set; }
        public ICollection<CustomerReviews>? CustomerReviews { get; set; }
        public ICollection<Passwords>? Passwords { get; set; }

    }
#nullable disable
}
