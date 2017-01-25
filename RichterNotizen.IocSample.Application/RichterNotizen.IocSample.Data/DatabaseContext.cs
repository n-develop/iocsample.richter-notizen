using System.Data.Entity;

namespace RichterNotizen.IocSample.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() : base("name=IocSample")
        {

        }
        public DbSet<Product> Products { get; set; }
    }
}
