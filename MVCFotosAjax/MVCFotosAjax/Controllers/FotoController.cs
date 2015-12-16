using MVCFotosAjax.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Web;
using System.Web.Mvc;

namespace MVCFotosAjax.Controllers
{
    public class FotoController : Controller
    {

        // GET: Foto
        public ActionResult IndiceFotos()
        {
            return View("Indice", Context.Fotos);
        }

        public ActionResult Detalles(int id)
        {
            return View("Detalles", Context.Fotos.Find(f => f.IdFoto == id));
        }

        public ActionResult Carrousel()
        {
            return View("Carrousel", Context.Fotos);
        }

        public ActionResult FavoritesSlideShow()
        {
            List<Foto> FotosFavoritas = new List<Foto>();
            List<int> IdsFotosFavoritas = Session["Favoritas"] as List<int>;
            if (IdsFotosFavoritas == null)
            {
                IdsFotosFavoritas = new List<int>();
            }
            Foto FotoActual;
            foreach (int item in IdsFotosFavoritas)
            {
                FotoActual = Context.Fotos.Find(f => f.IdFoto == item);
                if (FotoActual != null)
                {
                    FotosFavoritas.Add(FotoActual);
                }

            }
            return View("Carrousel", FotosFavoritas);
        }

        public ActionResult AddFavoritas(int id)
        {
            List<int> idsFavoritas = Session["Favoritas"] as List<int>;
            if (idsFavoritas == null)
            {
                idsFavoritas = new List<int>();
            }
            idsFavoritas.Add(id);
            Session["Favoritas"] = idsFavoritas;
            return Content("LA Foto se ha añadido a sus faroritas", "text/plain",System.Text.Encoding.Default);
        }

        public ViewResult Map()
        {
            return View("Map");
        }

        public FileContentResult GetImage(int id)
        {
            Foto photo = Context.Fotos.Find(p => p.IdFoto == id);
            if (photo != null)
            {
                string url= HttpContext.Server.MapPath(photo.URLFoto);
                byte[] fotoFichero = System.IO.File.ReadAllBytes(url);
                //ContentType ct = new ContentType();
                //ct.MediaType = MediaTypeNames.Image.Jpeg;
                //return File(fotoFichero, ct.MediaType);
                return File(fotoFichero, "image/jpg|image/png");
            }
            else
            {
                return null;
            }
        }

        //public ContentResult GetImage(int id)
        //{
        //    Foto photo = Context.Fotos.Find(p => p.IdFoto == id);
        //    if (photo != null)
        //    {
        //        return Content(photo.URLFoto);
        //        //return File(fotoFichero, "image/jpg|image/png");
        //    }
        //    else
        //    {
        //        return null;
        //    }
        //}
    }
}