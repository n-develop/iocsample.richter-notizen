using System.Data.Entity;

namespace RichterNotizen.IocSample.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() : base("name=IocSample")
        {
        }

        public DbSet<Product> Products { get; set; }

        /*
         * This method is never used. It exists, because of a reference-issue with the EntityFramecork.SqlServer.dll
         */
        public void EntityFrameworkSqlServerBinaryFix()
        {
            var instance = System.Data.Entity.SqlServer.SqlProviderServices.Instance;
        }
    }
}
