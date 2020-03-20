using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheHouseOfDelightV1.DbModel
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options)
            : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FoodTypes>()
                .HasKey(bc => new { bc.FoodID, bc.TypeID });

            modelBuilder.Entity<FoodTypes>()
                .HasOne(bc => bc.Food)
                .WithMany(b => b.Types)
                .HasForeignKey(bc => bc.FoodID);

            modelBuilder.Entity<FoodTypes>()
                .HasOne(bc => bc.Type)
                .WithMany(c => c.Foods)
                .HasForeignKey(bc => bc.TypeID);

            modelBuilder.Entity<FoodProducts>()
              .HasKey(bc => new { bc.FoodID, bc.ProductID });

            modelBuilder.Entity<FoodProducts>()
                .HasOne(bc => bc.Food)
                .WithMany(b => b.Products)
                .HasForeignKey(bc => bc.FoodID);

            modelBuilder.Entity<FoodProducts>()
                .HasOne(bc => bc.Product)
                .WithMany(c => c.Foods)
                .HasForeignKey(bc => bc.ProductID);
        }

        public DbSet<Food> Foods { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Types> Types { get; set; }
        public DbSet<Users> Users { get; set; }
        public object Product { get; internal set; }
    }
}
