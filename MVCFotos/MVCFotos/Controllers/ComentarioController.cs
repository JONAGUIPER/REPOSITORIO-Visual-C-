using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCFotos.Models;

namespace MVCFotos.Controllers
{
    public class ComentarioController : Controller
    {
        // GET: Comentario
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AgregarComentario(int? id)
        {
            
            if (id != null)
            {
                Comentario coment = new Comentario();
                coment.FotoId = id.GetValueOrDefault();
                ViewBag.NFoto = DbContext.Fotos.Find(f => f.IDFoto == id).Titulo;
                return View(coment);
            }
            else
            {
                return RedirectToAction("Index",DbContext.Fotos);
            }
      
        }
        [HttpPost]
        public ActionResult AgregarComentario(Comentario comentario)
        {
            if (ModelState.IsValid)
            {
                comentario.IdComentario = DbContext.Comentarios.Max(f=>f.IdComentario) + 1;
                comentario.FechaCreacion = DateTime.Now;
                DbContext.Comentarios.Add(comentario);
                Foto photo = (from f in DbContext.Fotos where f.IDFoto == comentario.FotoId select f).First<Foto>();
                return RedirectToAction("Details", "Foto", photo);
            }
            else
            {
                return View();
            }
        }

        [ChildActionOnly]
        public PartialViewResult _Comentarios(int IDFoto)
        {
            List<Comentario> RComentarios = DbContext.Comentarios.FindAll(f => f.FotoId == IDFoto);
            return PartialView(RComentarios);
        }
        [HttpGet]
        [ChildActionOnly]
        public ActionResult _AgregarComentario(int? id)
        {

            if (id != null)
            {
                Comentario coment = new Comentario();
                coment.FotoId = id.GetValueOrDefault();
                ViewBag.NFoto = DbContext.Fotos.Find(f => f.IDFoto == id).Titulo;
                return PartialView(coment);
            }
            else
            {
                return RedirectToAction("Index", DbContext.Fotos);
            }

        }

        [HttpPost]
        //[ChildActionOnly]
        public ActionResult _AgregarComentario(Comentario comentario)
        {
            if (ModelState.IsValid)
            {
                comentario.IdComentario = DbContext.Comentarios.Max(f => f.IdComentario) + 1;
                comentario.FechaCreacion = DateTime.Now;
                DbContext.Comentarios.Add(comentario);
                Foto photo = (from f in DbContext.Fotos where f.IDFoto ==comentario.FotoId select f).First<Foto>();
                return RedirectToAction("Details", "Foto", photo);
            }
            else
            {
                return View();
            }
        }
    }
}