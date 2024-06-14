using Microsoft.EntityFrameworkCore;

namespace Asset_Management_System.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<ProductModel> Products { get; set; }
    }
}
