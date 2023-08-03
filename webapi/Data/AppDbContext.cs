using Microsoft.EntityFrameworkCore;
using webapi.Data.Models;

namespace webapi.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options) { }

        public DbSet<Admin> Admin { get; set; }

        public DbSet<Product> Product { get; set; }

        public DbSet<Cart> Cart { get; set; }

        public DbSet<Client> Clients { get; set; }

        public DbSet<Feedback> Feedback { get; set; }

        public DbSet<User> User { get; set; }

        public DbSet<Wishlist> Wishlist { get; set; }
    }
}
