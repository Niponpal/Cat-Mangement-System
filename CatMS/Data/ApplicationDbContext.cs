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
        // DbSet properties for your entities go here
         public DbSet<Cat> Cats { get; set; }
         public DbSet<Seller> Sellers { get; set; }
         public DbSet<Buyer> Buyers { get; set; }

    }

}