using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace YellowBucket1.Models
{
#nullable enable
    public class MoviesGenres
    {
        [Required]
        public int MoviesID { get; set; }

        [Required]
        public int GenresID { get; set; }

        
        public Movies? Movies { get; set; }
        public Genres? Genres { get; set; }


    }
#nullable disable
}
