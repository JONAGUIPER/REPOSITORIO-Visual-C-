using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVCFotos
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute(
                            name: "FotoTitleRoute",
                            url: "Foto/Title/{title}",
                            defaults: new { controller = "Foto", action = "DetailsByTitle" }
                        );
            routes.MapRoute(
                            name: "FotoTitleRoute2",
                            url: "{title}",
                            defaults: new { controller = "Foto", action = "DetailsByTitle" }
                        );
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );


        }
    }
}
