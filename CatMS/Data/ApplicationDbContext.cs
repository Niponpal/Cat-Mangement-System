using CatMS.Models;
using Microsoft.EntityFrameworkCore;

namespace CatMS.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cat>()
               .HasOne(c => c.Seller)
               .WithMany(s => s.Cats)
               .HasForeignKey(c => c.SellerId)
               .OnDelete(DeleteBehavior.Cascade);

            // Buyer → Cat (1-M)
            modelBuilder.Entity<Cat>()
                .HasOne(c => c.Buyer)
                .WithMany(b => b.Cats)
                .HasForeignKey(c => c.BuyerId)
                .OnDelete(DeleteBehavior.SetNull);
        }

        // DbSet properties for your entities go here
        public DbSet<Cat> Cats { get; set; }
         public DbSet<Seller> Sellers { get; set; }
         public DbSet<Buyer> Buyers { get; set; }

       

    }

}