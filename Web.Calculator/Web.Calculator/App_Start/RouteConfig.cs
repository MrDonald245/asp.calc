using System.Web.Mvc;
using System.Web.Routing;

namespace Web.Calculator
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{par1}/{par2}",
                defaults: new
                {
                    controller = "Home",
                    action = "Index",
                    par1 = UrlParameter.Optional,
                    par2 = UrlParameter.Optional
                }
            );
        }
    }
}