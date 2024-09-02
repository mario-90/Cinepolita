using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Boletos_de_cine.Models
{
    public class Movie
    {
        [Key]
        public int MovieId { get; set; }

        [Required]
        [StringLength(100)]
        public string Title { get; set; }

        [StringLength(50)]
        public string Genre { get; set; }

        public TimeSpan Duration { get; set; }

        [StringLength(100)]
        public string Director { get; set; }

        public ICollection<Showtime> Showtimes { get; set; }
    }
}
