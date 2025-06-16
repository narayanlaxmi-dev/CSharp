using EFDemo.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;
using WebApp9.Models;

// https://learn.microsoft.com/en-us/ef/core/dbcontext-configuration/ refer this documentation 
namespace WebApp9.Data
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options)
      : base(options)
        {

        }

        public DbSet<User> User { get; set; }
        public DbSet<UserProfile> UserProfile { get; set; }

        public DbSet<Product> Products { get; set; }

        // Fluent API 
        public DbSet<Car> Cars { get; set; }
        public DbSet<CarShowRoom> CarShowRooms { get; set; }
        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            // configure Car 
            modelbuilder.Entity<Car>().HasKey(c => c.CarId);
            modelbuilder.Entity<Car>().Property(C=>C.CarEngine).IsRequired().HasMaxLength(100);
            modelbuilder.Entity<Car>().HasOne(c => c.Carshowroom).WithMany(s => s.Car).HasForeignKey(s=>s.CarShowRoomId);

            // Configure CarShowroom
            modelbuilder.Entity<CarShowRoom>().HasKey(c => c.Id);
            modelbuilder.Entity<CarShowRoom>().Property(s=>s.FuelType).IsRequired().HasMaxLength(5);
            

        } 
    }
}
