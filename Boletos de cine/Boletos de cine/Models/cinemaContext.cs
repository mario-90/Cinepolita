using Microsoft.EntityFrameworkCore;

namespace Boletos_de_cine.Models
{
    public class cinemaContext : DbContext
    {
        public cinemaContext(DbContextOptions<cinemaContext> options)
            : base(options)
        {
        }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Showtime> Showtimes { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Customer> Customers { get; set; }
    }
}
