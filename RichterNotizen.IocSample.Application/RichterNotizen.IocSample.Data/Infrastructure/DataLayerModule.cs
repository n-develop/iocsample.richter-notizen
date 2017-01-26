using Autofac;

namespace RichterNotizen.IocSample.Data.Infrastructure
{
    public class DataLayerModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<DatabaseContext>().AsSelf();
            builder.RegisterType<ProductRepository>().As<IProductRepository>();

            base.Load(builder);
        }
    }
}
