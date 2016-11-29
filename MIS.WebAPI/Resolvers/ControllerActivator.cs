using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Http.Dispatcher;

namespace MIS.WebAPI.Resolvers
{
    public class ControllerActivator : IHttpControllerActivator
    {
        private readonly IUnityContainer container;

        public ControllerActivator(IUnityContainer container)
        {
            this.container = container;
        }

        public IHttpController Create(HttpRequestMessage request, HttpControllerDescriptor controllerDescriptor,
            Type controllerType)
        {
            return container.RegisterInstance(controllerType) as IHttpController;
        }
    }
}