using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;
// https://learn.microsoft.com/en-us/ef/core/dbcontext-configuration/ refer this documentation 
namespace WebApplication1.Data
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
