using System.Web.Mvc;
using System.Web.Routing;

namespace MIS.WebClient
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                            "Default",
                            "{controller}/{action}/{id}",
                            new { controller = "Home", action = "Login", id = UrlParameter.Optional },
                            new[] {"MIS.WebClient.Controllers"}
                );
            }
    }
}
