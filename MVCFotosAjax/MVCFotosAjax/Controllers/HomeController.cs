using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCFotosAjax.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ContentResult GetBackground()
        {
            string style;
            if (Session["BackgroundColor"] != null)
            {
                style = String.Format("background-color:{0};{1}", Session["BackgroundColor"], ";Hola");
            }
            else
            {
                style = "background-color:#dc9797";
            }
            return Content(style);
        }

        public ActionResult SetBackground(string color)
        {
            HttpCookie galleta = new HttpCookie("Campurrianas");

            galleta["Hora"] = DateTime.Now.ToLongDateString();
            galleta["UserNme"] = Profile.UserName;
            galleta["ColorPreferido"] = color;
            //Request.Cookies.Add(galleta);
            Response.Cookies.Add(galleta);//agrega la galleta en el cliente
            galleta.Expires = DateTime.Now.AddMinutes(5);

            HttpCookie vueltaGalleta = Request.Cookies["Campurriadas"];//obtenemos la galleta
            DateTime istante = new DateTime();
            //istante = Convert.ToDateTime(vueltaGalleta["Hora"]);

            Session["BackgroundColor"] = color;
            return View("Index");
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }


    }
}