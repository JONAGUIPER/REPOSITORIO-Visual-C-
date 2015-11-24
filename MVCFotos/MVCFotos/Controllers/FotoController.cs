using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCFotos.Models;

namespace MVCFotos.Controllers
{
    public class FotoController : Controller
    {
        
        // GET: Foto
        public ActionResult Index()
        {
            return View(DbContext.Fotos);
        }
        public ActionResult Details(int IDFoto)
        {
            return View(DbContext.Fotos.Find(f => f.IDFoto == IDFoto));
        }
    }
}