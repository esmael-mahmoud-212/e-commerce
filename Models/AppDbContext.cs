using Microsoft.EntityFrameworkCore;

namespace E_commerce.Models
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-STJBOMO;Database=E-commerce;" +
                "User Id=sa;Password=mohammed;Integrated Security=True;Encrypt=False");
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> categories { get; set; }
        public DbSet<Order> orders { get; set; }
        public DbSet<Review> reviews { get; set; }
        public DbSet<User> users { get; set; }

    }
}
