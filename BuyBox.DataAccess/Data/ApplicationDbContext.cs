using BuyBox.Models;
using Microsoft.EntityFrameworkCore;

namespace BuyBox.DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }
        public DbSet<Category> Categories { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
               new Category { Id = 1, Name = "Sand", DisplayOrder = 1 },
               new Category { Id = 2, Name = "Brick", DisplayOrder = 2 },
               new Category { Id = 3, Name = "Blue metal", DisplayOrder = 3 },
               new Category { Id = 4, Name = "AAC Block", DisplayOrder = 4 },
               new Category { Id = 5, Name = "Cement", DisplayOrder = 5 },
               new Category { Id = 6, Name = "Block Paste", DisplayOrder = 6 }
               );
        }
    }
}
