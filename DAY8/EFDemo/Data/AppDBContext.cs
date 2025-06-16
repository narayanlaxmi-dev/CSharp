using Microsoft.EntityFrameworkCore;
using EFDemo.Models;

// https://learn.microsoft.com/en-us/ef/core/dbcontext-configuration/ refer this documentation 
namespace EFDemo.Data
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options)
      : base(options)
        {

        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teacher { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<UserProfile> UserProfile { get; set; }
        public DbSet<Blog> Blog { get; set; }
        public DbSet<Post> Post { get; set; }
        public DbSet<Book> Book { get; set; }
        public DbSet<Author> Author { get; set; }
        public DbSet<EFDemo.Models.UserProfile1_1> UserProfile1_1 { get; set; } = default!;


    }
}
