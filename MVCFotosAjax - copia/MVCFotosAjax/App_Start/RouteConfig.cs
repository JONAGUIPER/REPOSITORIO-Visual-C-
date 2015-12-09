using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVCFotosAjax
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "IndiceFotos",
                url: "Foto/Indice/{id}",
                defaults: new { controller = "Foto", action = "IndiceFotos", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "inicio",
                url: "Foto",
                defaults: new { controller = "Foto", action = "IndiceFotos", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
