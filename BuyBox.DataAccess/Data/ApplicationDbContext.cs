using BuyBox.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BuyBox.DataAccess.Data
{
    public class ApplicationDbContext : IdentityDbContext <IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<Category>().HasData(
               new Category { Id = 1, Name = "Sand", DisplayOrder = 1 },
               new Category { Id = 2, Name = "Brick", DisplayOrder = 2 },
               new Category { Id = 3, Name = "Blue metal", DisplayOrder = 3 },
               new Category { Id = 4, Name = "AAC Block", DisplayOrder = 4 },
               new Category { Id = 5, Name = "Cement", DisplayOrder = 5 },
               new Category { Id = 6, Name = "Block Paste", DisplayOrder = 6 }
               );
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Title= "Regular Brick",
                    Description= "This is an regular brick",
                    ListPrice = 12,
                    Price =11,
                    Price50 = 10,
                    Price100 = 8,
                    CategoryId = 2,
                    ImageUrl =""
                },
                new Product
                {
                    Id = 2,
                    Title = "Premium Brick",
                    Description = "This is an Premium brick",
                    ListPrice = 15,
                    Price = 14,
                    Price50 = 12,
                    Price100 = 10,
                    CategoryId = 2,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 3,
                    Title = "M-Sand",
                    Description = "This is M-sand used for building purpose",
                    ListPrice = 70,
                    Price = 65,
                    Price50 = 65,
                    Price100 = 60,
                    CategoryId = 1,
                    ImageUrl = ""
                },
                 new Product
                 {
                     Id = 4,
                     Title = "P-Sand",
                     Description = "This is P-sand used for building purpose",
                     ListPrice = 60,
                     Price = 60,
                     Price50 = 55,
                     Price100 = 50,
                     CategoryId = 1,
                     ImageUrl = ""
                 },
                  new Product
                  {
                      Id = 5,
                      Title = "River-Sand",
                      Description = "This is River-sand used for building purpose",
                      ListPrice = 110,
                      Price = 110,
                      Price50 =105,
                      Price100 =100,
                      CategoryId = 1,
                      ImageUrl = ""
                  },
                  new Product
                  {
                      Id = 6,
                      Title = "Blue Metal",
                      Description = "This is Blue Metal used for building purpose",
                      ListPrice = 110,
                      Price = 110,
                      Price50 = 105,
                      Price100 = 100,
                      CategoryId = 3,
                      ImageUrl = ""
                  },
                   new Product
                   {
                       Id = 7,
                       Title = " 4 inch AAC Block",
                       Description = "This is AAC Block used for building purpose",
                       ListPrice = 60,
                       Price = 60,
                       Price50 = 55,
                       Price100 = 52,
                       CategoryId = 4,
                       ImageUrl = ""
                   },
                   new Product
                   {
                       Id = 8,
                       Title = " 6 inch AAC Block",
                       Description = "This is AAC Block used for building purpose",
                       ListPrice = 60,
                       Price = 60,
                       Price50 = 55,
                       Price100 = 52,
                       CategoryId = 4,
                       ImageUrl = ""
                   },
                   new Product
                   {
                       Id = 9,
                       Title = " 9 inch AAC Block",
                       Description = "This is AAC Block used for building purpose",
                       ListPrice = 60,
                       Price = 60,
                       Price50 = 55,
                       Price100 = 52,
                       CategoryId = 4,
                       ImageUrl = ""
                   },
                   new Product
                   {
                       Id = 10,
                       Title = "Coromental Cement",
                       Description = "This is best quality cement used for building purpose",
                       ListPrice = 420,
                       Price = 420,
                       Price50 = 415,
                       Price100 = 410,
                       CategoryId = 5,
                       ImageUrl = ""
                   },
                    new Product
                    {
                        Id = 11,
                        Title = "Priya Cement",
                        Description = "This is best quality cement used for building purpose",
                        ListPrice = 400,
                        Price = 400,
                        Price50 = 395,
                        Price100 = 390,
                        CategoryId = 5,
                        ImageUrl = ""
                    },
                     new Product
                     {
                         Id = 12,
                         Title = "AAC block Paste",
                         Description = "This is best quality AAC BLock paste used for building purpose",
                         ListPrice = 400,
                         Price = 400,
                         Price50 = 395,
                         Price100 = 390,
                         CategoryId = 6,
                         ImageUrl = ""
                     }
                );

        }
    }
}
