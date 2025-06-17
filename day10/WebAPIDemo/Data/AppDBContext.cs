using WebAPIDemo.Model;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;


// https://learn.microsoft.com/en-us/ef/core/dbcontext-configuration/ refer this documentation 
namespace WebApp9.Data
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options)
      : base(options)
        {

        }

        public DbSet<Student> Students { get; set; }

    }

}
