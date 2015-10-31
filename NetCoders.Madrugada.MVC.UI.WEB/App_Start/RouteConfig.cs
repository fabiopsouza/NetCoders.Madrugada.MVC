using System.Web.Mvc;
using System.Web.Routing;

namespace NetCoders.Madrugada.MVC.UI.WEB
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Ficante", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
