using ManejoVistas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ManejoVistas.Controllers
{
    public class FrutaController : Controller
    {
        // GET: Fruta
        public ActionResult Index()
        {
            return View("Index",FrutasContext.Frutas);
        }

        public ActionResult Create()
        {
            return View("Create");
        }
        
        [HttpPost]
        public ActionResult Create(Fruta fruta)
        {
            if (ModelState.IsValid)
            {
                fruta.IdFruta = FrutasContext.Frutas.Max(f=>f.IdFruta)+1;
                FrutasContext.Frutas.Add(fruta);
                return View("Index",FrutasContext.Frutas);
            }
            else
            {
                return View("Create");
            }
        }

        public ActionResult Delete(int IdFruta)
        {
            return View("Delete",FrutasContext.Frutas.Find(f=>f.IdFruta==IdFruta));
        }
        [HttpPost]
        public ActionResult Delete(int? IdFruta)
        {
            if (FrutasContext.Frutas.RemoveAll(f => f.IdFruta == IdFruta) >0)
            {
                 return View("Index",FrutasContext.Frutas);
            }
            else
            {
                return View("Error");
            }
        }
        [ChildActionOnly]
        public ActionResult _FrutaGallery(int cantidad = 0)
        {
            List<Fruta> frutas;
            if (cantidad==0)
            {
                frutas = FrutasContext.Frutas;
            }
            else
            {
                frutas = (from f in FrutasContext.Frutas select f).Take(cantidad).ToList();
            }
            return PartialView("_FrutaGallery", frutas);
        }
    }
}