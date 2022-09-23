
using Microsoft.EntityFrameworkCore;
namespace webApi_EFCore.Models
{
    public class CustomerdbContext : DbContext
    {
        public CustomerdbContext(DbContextOptions<CustomerdbContext> options) : base(options)
        {

        }

        public DbSet<Customer> Customers { get; set; }
    }
}
