namespace RichterNotizen.IocSample.Data.Migrations
{
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<RichterNotizen.IocSample.Data.DatabaseContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(RichterNotizen.IocSample.Data.DatabaseContext context)
        {
            context.Products.AddOrUpdate(
                new Product
                {
                    Name = "Cool Product",
                    Sku = "Prod-30194",
                    Price = 3.99m
                },
                new Product
                {
                    Name = "Another Product",
                    Sku = "Prod-19472",
                    Price = 19m
                });
        }
    }
}
