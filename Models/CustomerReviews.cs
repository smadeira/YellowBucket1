﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace YellowBucket1.Models {
#nullable enable
    public class CustomerReviews {
        [Required]
        public int ID { get; set; }

        [Required]
        public int CustomersID { get; set; }

        [Required]
        public int MoviesID { get; set; }

        [MaxLength(4096)]
        [Column(TypeName = "varchar(4096)")]
        public string? Review { get; set; }

        public int? Kernals { get; set; }

        public DateTime? DeletedAt { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; }

        [Required]
        public DateTime UpdatedAt { get; set; }

        public virtual Customers Customer { get; set; }
    }
#nullable disable
}
