using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Owin;
using Owin;
using System.Web.Http;
using Microsoft.Owin.Security.OAuth;
using MIS.WebAPI.Providers;
using MIS.WebAPI.Resolvers;
using System.Web.Http.Dispatcher;
using System.Web.Mvc;
using System.Web.Optimization;

[assembly: OwinStartup(typeof(MIS.WebAPI.Startup))]

namespace MIS.WebAPI
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureOAuth(app);
            AreaRegistration.RegisterAllAreas();
            UnityConfig.RegisterComponents();
            HttpConfiguration config = new HttpConfiguration();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            BundleConfig.RegisterBundles(BundleTable.Bundles);




            //WebApiConfig.Register(config);
            //var container = UnityConfig.GetConfiguredContainer();
            //var controllerActivator = new ControllerActivator(container);
            //config.Services.Replace(typeof(IHttpControllerActivator), controllerActivator);

            app.UseWebApi(config);

           

        }

        public void ConfigureOAuth(IAppBuilder app)
        {
            OAuthAuthorizationServerOptions OAuthServerOptions = new OAuthAuthorizationServerOptions()
            {
                AllowInsecureHttp = true,
                TokenEndpointPath = new PathString("/token"),
                AccessTokenExpireTimeSpan = TimeSpan.FromDays(1),
                Provider = new SimpleAuthorizationServerProvider()
            };

            // Token Generation
            app.UseOAuthAuthorizationServer(OAuthServerOptions);
            app.UseOAuthBearerAuthentication(new OAuthBearerAuthenticationOptions());

        }
    }
}
