using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Net.Sockets;

namespace Boletos_de_cine.Models
{
    public class Showtime
    {
        [Key]
        public int ShowtimeId { get; set; }

        [Required]
        public DateTime StartTime { get; set; }

        public int MovieId { get; set; }
        public Movie Movie { get; set; }

        public ICollection<Ticket> Tickets { get; set; }
    }
}
