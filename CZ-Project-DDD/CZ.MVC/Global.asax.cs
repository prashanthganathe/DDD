using CZ.MVC.App_Start;
using CZ.MVC.AutoMapper;
using System;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;


namespace CZ.MVC
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            ViewEngines.Engines.Clear();
            ViewEngines.Engines.Add(new RazorViewEngine());

            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            AutoMapperConfig.RegisterMappings();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            MvcHandler.DisableMvcResponseHeader = true;
        }


        protected void Application_PreSendRequestHeaders()
        {
            Response.Headers.Remove("Server");
            Response.Headers.Remove("X-AspNet-Version");
        }


        private void Application_BeginRequest(Object source, EventArgs e)
        {
            try
            {
                HttpApplication application = (HttpApplication)source;
                HttpContext context = application.Context;

                //if (HttpContext.Current.Request.IsSecureConnection == false)
                //{
                //    Response.Redirect("https://" + Request.ServerVariables["HTTP_HOST"] + HttpContext.Current.Request.RawUrl);
                //}

                string culture = null;
                if (context.Request.UserLanguages != null && Request.UserLanguages.Length > 0)
                {
                    culture = Request.UserLanguages[0];
                    Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo(culture);
                    Thread.CurrentThread.CurrentUICulture = Thread.CurrentThread.CurrentCulture;
                }
                //  Response.AddHeader("X-Frame-Options", "DENY");
            }
            catch { }
        }
        protected void Session_End(object sender, EventArgs e)
        {
            Session.Abandon();
            Session.Clear();
            Session.RemoveAll();

            
        }

    }
}
