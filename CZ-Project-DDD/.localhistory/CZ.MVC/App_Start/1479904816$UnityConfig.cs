using System.Web.Mvc;
using Microsoft.Practices.Unity;
using Unity.Mvc5;
using CZ_Application.Interface;
using CZ_Application;

namespace CZ.MVC
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();

            container.RegisterType<IClientAppService, ClientAppService>();
            container.RegisterType<IClientAppService, ClientAppService>();
            container.RegisterType<IClientAppService, ClientAppService>();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}