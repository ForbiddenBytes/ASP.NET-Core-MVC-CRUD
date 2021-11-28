using MyBooks.Web.Models;
using Microsoft.EntityFrameworkCore;

namespace MyBooks.Web.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
                
        }
         public DbSet<Category>Categories { get; set; }
    }
}
