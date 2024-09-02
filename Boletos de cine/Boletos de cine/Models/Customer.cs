using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Boletos_de_cine.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        [StringLength(100)]
        public string Email { get; set; }

        [StringLength(15)]
        public string PhoneNumber { get; set; }

        public ICollection<Reservation> Reservations { get; set; }
    }
}
