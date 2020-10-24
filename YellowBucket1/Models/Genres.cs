using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;


namespace YellowBucket1.Models
{
#nullable enable
    public class Genres
    {
        [Required]
        public int ID { get; set; }

        [Required]
        [MaxLength(32)]
        [Column(TypeName = "varchar(32)")]
        public string Name { get; set; }

        public DateTime? DeletedAt { get; set; }
        [Required]
        public DateTime CreatedAt { get; set; }
        [Required]
        public DateTime UpdatedAt { get; set; }

        public ICollection<MoviesGenres>? MoviesGenres { get; set; }
    }
#nullable disable
}
