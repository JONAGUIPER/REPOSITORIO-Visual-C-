using MVCFotosAjax.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Web;
using System.Web.Mvc;
//using MVCFotosAjax.GeoCodeService;//ESTE ES UN SERVICIO ALOJADO EN AZURE PERO NO SE LOGRO HACER FUNCIONAR
using MVCFotosAjax.ServicioLocalDeUbicacion;


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

        #region Crear
        [Authorize]
        public ActionResult Create()
        {
            Foto photo = new Foto();
            return View("Create", photo);
        }

        [Authorize]
        [HttpPost]
        public ActionResult Create(Foto Photo, HttpPostedFileBase image)
        {
            if (Photo.Location != "")
            {
                string stringLongLat = CheckLocation(Photo.Location);
                if (stringLongLat.StartsWith("Success"))
                {
                    string[] coordenadas = stringLongLat.Split(':');
                    Photo.Latitude = Convert.ToDouble(coordenadas[1]);
                    Photo.Longitude = Convert.ToDouble(coordenadas[2]);
                }

            }
            if (!ModelState.IsValid)
            {
                return View("Create", Photo);
            }
            else
            {
                string fileName = image.FileName.ToLower();
                Photo.URLFoto = "/images/" + fileName;
                image.SaveAs(Server.MapPath("~" + Photo.URLFoto));
                Photo.IdFoto = Context.Fotos.Max(f => f.IdFoto)+1;
                Context.Fotos.Add(Photo);
                return View("Indice",Context.Fotos);
            }
            
        }
        #endregion

        private string CheckLocation(string location)
        {
            LocationCheckerServiceClient cliente = null;
            string response = "";
            try
            {
                cliente = new LocationCheckerServiceClient();
                response = cliente.GetLocation(location);
            }
            catch (Exception e)
            {
                response = "Error: " + e.Message;
            }
            return response;
        }
    }
}