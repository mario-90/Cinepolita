using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Boletos_de_cine.Models
{
    public class Reservation
    {
        [Key]
        public int ReservationId { get; set; }

        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

        public DateTime ReservationDate { get; set; }

        public ICollection<Ticket> Tickets { get; set; }
    }
}
