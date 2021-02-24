using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace YellowBucket1.Models {
#nullable enable
    public class Passwords {
        [Required, MaxLength(128)]
        [Column(TypeName = "varchar(128)")]
        public string Username { get; set; }

        [Required, MaxLength(128)]
        [Column(TypeName = "varchar(128)")]
        public string Password { get; set; }

        public int? CustomersID { get; set; }

        public DateTime? DeletedAt { get; set; }
        [Required]
        public DateTime CreatedAt { get; set; }
        [Required]
        public DateTime UpdatedAt { get; set; }

        public Customers? Customers { get; set; }
    }
#nullable disable
}

