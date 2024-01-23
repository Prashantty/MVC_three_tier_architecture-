using Microsoft.EntityFrameworkCore;
using WebApiDemo.Model;

namespace WebApiDemo.Context
{
    public class WebDbContext : DbContext
    {
        public WebDbContext()
        {
            
        }

        public WebDbContext(DbContextOptions<WebDbContext> options ) :base(options)
        {
            
        }

        public DbSet<Clint> Clints { get; set; }    


    }
}
