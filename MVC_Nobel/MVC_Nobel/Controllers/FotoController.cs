using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Nobel.Models;

namespace MVC_Nobel.Controllers
{
    public class FotoController : Controller
    {
        [OutputCache(Duration =600,
            Location =System.Web.UI.OutputCacheLocation.Server,
            VaryByParam ="None")]
        // GET: Foto
        public ActionResult Index()
        {
            List<Foto> fotos = Context.Fotos;

            return View("Index", fotos);
        }

        public ActionResult Detalles(int id)
        {
            Foto foto = (from f in Context.Fotos
                         where f.fotoID==id
                         select f).First<Foto>();
           
            return View("Detalles", foto);
        }
    }
}