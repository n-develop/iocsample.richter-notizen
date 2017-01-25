using System.Data.Entity;

namespace RichterNotizen.IocSample.Data
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
    }
}
