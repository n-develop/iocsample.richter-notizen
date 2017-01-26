using Autofac;
using RichterNotizen.IocSample.Data.Infrastructure;

namespace RichterNotizen.IocSample.Business.Infrastructure
{
    public class BusinessLayerModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterModule<DataLayerModule>();
            builder.RegisterType<ProductService>().As<IProductService>();

            base.Load(builder);
        }
    }
}
