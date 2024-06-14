using Microsoft.EntityFrameworkCore;

using MVC_Application.Models;

namespace MVC_Application.Db_context
{
    public class ApplicationDbContext : DbContext
    {
       public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {
        }
        
        public DbSet<Product> Products { get; set; }
    }
}
