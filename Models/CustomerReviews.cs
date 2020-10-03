using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;


namespace YellowBucket1.Models
{
    public class CustomerReviews
    {
        [Required]
        public int ID { get; set; }
    }
}
