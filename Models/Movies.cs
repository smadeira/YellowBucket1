using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace YellowBucket1.Models {
#nullable enable
    public class Movies {
        [Required]
        public int ID { get; set; }

        [Required, MaxLength(128)]
        [Column(TypeName = "varchar(128)")]
        public string? Title { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        [MaxLength(8)]
        [Column(TypeName = "varchar(8)")]
        public string? Rating { get; set; }

        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Price { get; set; }

        [MaxLength(4096)]
        [Column(TypeName = "varchar(4096)")]
        public string? Description { get; set; }

        /* Need to clean up the validation by removing the ability
           to remove null values once the pages are created */
        public int? Length { get; set; }
        
        [Required]
        public bool IsDVD { get; set; }
        [Required]
        public bool IsBluRay { get; set; }
        [MaxLength(128)]
        [Column(TypeName = "varchar(128)")]
        public string? CoverPhoto { get; set; } 
        public DateTime? DeletedAt { get; set; }
        [Required]
        public DateTime? CreatedAt { get; set; }
        [Required]
        public DateTime? UpdatedAt { get; set; }

        public ICollection<Wishlists>? Wishlists { get; set; }
        public ICollection<CustomerReviews>? CustomerReviews { get; set; }
        public ICollection<Inventories>? Inventories { get; set; }
        public ICollection<MoviesGenres>? MoviesGenres { get; set; }
    }
#nullable disable
}
