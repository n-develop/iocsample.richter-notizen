using Autofac;
using Autofac.Integration.Mvc;
using RichterNotizen.IocSample.Business.Infrastructure;
using System.Web.Mvc;

namespace RichterNotizen.IocSample.Application
{
    public class AutofacConfig
    {
        public static void ConfigureContainer()
        {
            var builder = new ContainerBuilder();

            builder.RegisterControllers(typeof(MvcApplication).Assembly);

            builder.RegisterModule<BusinessLayerModule>();

            var container = builder.Build();

            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}