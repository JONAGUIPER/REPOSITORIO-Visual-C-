using MVCFotosAjax.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCFotosAjax.Controllers
{
    public class FotoController : Controller
    {
        
        // GET: Foto
        public ActionResult IndiceFotos()
        {
            return View("Indice",Context.Fotos);
        }

        public ActionResult Detalles(int id)
        {
            return View("Detalles", Context.Fotos.Find(f => f.IdFoto == id));
        }

        public ActionResult Carrousel()
        {
            return View("Carrousel", Context.Fotos);
        }
    }
}