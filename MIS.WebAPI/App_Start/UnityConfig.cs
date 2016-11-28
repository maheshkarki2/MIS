using Microsoft.Practices.Unity;
using System.Web.Http;
using MIS.WebAPI.Helper;
using Unity.WebApi;

namespace MIS.WebAPI
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();                        
            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(GetConfiguredContainer());
        }
        public static IUnityContainer GetConfiguredContainer()
        {
            IUnityContainer container = new UnityContainer();
            IocHelper.ConfigureContainer(container);

            return container;
        }
    }
}