using System.Web;
using System.Web.Mvc;
using System.Web.Routing;


namespace RichterNotizen.IocSample.Application
{
    public class MvcApplication : HttpApplication
    {
        protected void Application_Start()
        {
            AutofacConfig.ConfigureContainer();
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}
