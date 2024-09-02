using System;
using System.ComponentModel.DataAnnotations;

namespace Boletos_de_cine.Models
{
    public class Ticket
    {
        [Key]
        public int TicketId { get; set; }

        public int ShowtimeId { get; set; }
        public Showtime Showtime { get; set; }

        public int ReservationId { get; set; }
        public Reservation Reservation { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public int SeatNumber { get; set; }
    }
}
