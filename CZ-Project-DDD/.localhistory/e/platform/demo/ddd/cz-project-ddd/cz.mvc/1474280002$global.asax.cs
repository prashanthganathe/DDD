using CZ.MVC.AutoMapper;
using System.Web.Mvc;
using System.Web.Routing;

namespace CZ.MVC
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            AutoMapperConfig.RegisterMappings(); 
        }
    }
}
