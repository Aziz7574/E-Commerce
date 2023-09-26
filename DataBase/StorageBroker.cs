using E_Commerce.Entities.Classes;
using E_Commerce.Entities.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;

namespace E_Commerce.DataBase
{
    public class StorageBroker : DbContext
    {
        public DbSet<User> Users { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<ShoppingCard> ShoppingCards { get; set; }

        public DbSet<ShoppingCardHistory> ShoppingCardHistories { get; set; }

        public StorageBroker() => Database.EnsureCreated();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "Data Source =..\\..\\..\\dbSource.db";
            optionsBuilder.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
            optionsBuilder.UseSqlite(connectionString);
        }
      /*  protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>().ToTable("Orders")
                .Property(c => c.ClassCondition)
                .HasConversion<int>();   

        }*/

      
    }
}
