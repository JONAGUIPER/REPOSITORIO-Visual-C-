using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace MVCFotosAjax
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.MapHttpAttributeRoutes();

            //config.Routes.MapHttpRoute(
            //    name: "DefaultApi",
            //    routeTemplate: "api/{controller}/{id}",
            //    defaults: new { id = RouteParameter.Optional }
            //);

             config.Routes.MapHttpRoute(name: "PhotoIdApi",
                routeTemplate: "api/photos/{id}",
                defaults:
                new { controller = "FotoApi", action = "GetFotoById" },
                constraints: new { id = "[0-9]+" });

            config.Routes.MapHttpRoute(name: "PhotoTitleApi",
                routeTemplate: "api/photos/{tituloFoto}",
                defaults:
                new{controller = "FotoApi",action = "GetFotoByTitulo" });

            config.Routes.MapHttpRoute(name: "PhotosApi",
                routeTemplate: "api/photos",
                defaults:
                new{controller = "FotoApi",action = "GetAllFotos"});

            config.Routes.MapHttpRoute(name: "PhotoUrlApi",
                routeTemplate: "api/photosUrl/{id}",
                defaults:
                new { controller = "FotoApi", action = "GetFotoUrlById" },
                constraints: new { id = "[0-9]+" });


            var json = config.Formatters.JsonFormatter;

            json.SerializerSettings.PreserveReferencesHandling = Newtonsoft.Json.PreserveReferencesHandling.Objects;
            config.Formatters.Remove(config.Formatters.XmlFormatter);

        }
    }
}
