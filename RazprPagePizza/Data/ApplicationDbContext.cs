using Microsoft.EntityFrameworkCore;
using RazprPagePizza.Model;

namespace RazprPagePizza.Data
{
    public class ApplicationDbContext: DbContext
    {
        public DbSet<PizzaOrder> PizzaOrders { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :base(options)
        {
             
        }
    }
}
