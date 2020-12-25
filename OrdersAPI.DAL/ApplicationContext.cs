using Microsoft.EntityFrameworkCore;
using OrdersAPI.DAL.Models;

namespace OrdersAPI.DAL
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Order> Orders { get; set; }
    }
}
