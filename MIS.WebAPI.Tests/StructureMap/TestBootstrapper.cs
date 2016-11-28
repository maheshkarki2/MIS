using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http;
using Microsoft.Practices.Unity;
using MIS.WebAPI.Helper;
using StructureMap;
using StructureMap;
using Unity.WebApi;

namespace MIS.WebAPI.Tests.StructureMap
{
    public class TestBootstrapper
    {
        public static void SetUp()
        {
            RegisterComponents();
        }
        public static void RegisterComponents()
        {
            // Set up Unity for web api controllers
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
