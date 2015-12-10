using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCFotosAjax.Models;

namespace MVCFotosAjax.Controllers
{
    public class ComentarioController : Controller
    {
        // GET: Comentario
        public PartialViewResult _ComentariosFoto(int id)
        {
            var comentarios = (from c in Context.Comentarios
                               where c.IdFoto == id
                               select c);
            ViewBag.IDFoto = id;
            return PartialView("_ComentariosFoto", comentarios.ToList<Comentario>());
        }

        [HttpPost]
        public PartialViewResult _ComentariosFoto(Comentario comentario, int id)
        {
            Context.Comentarios.Add(comentario);
            comentario.IdComentario = Context.Comentarios.Max(c => c.IdComentario) + 1;
            comentario.IdFoto = id;
            ViewBag.IDFoto = id;
            var comentarios = (from c in Context.Comentarios
                               where c.IdFoto == id
                               select c);
            
            return PartialView("_ComentariosFoto", comentarios.ToList());
        }

        //[AcceptVerbs(HttpVerbs.Get|HttpVerbs.Post)]
        [ChildActionOnly]
        public PartialViewResult _CrearComentario(int id)
        {
            Comentario comentario = new Comentario();
            comentario.IdFoto = id;
            ViewBag.IDFoto = id;
            return PartialView("_CrearComentario", comentario);
        }

        //[HttpPost]
        //public ActionResult _CrearComentario(Comentario comentario, int id)
        //{
        //    comentario.IdComentario = Context.Comentarios.Max(c => c.IdComentario) + 1;
        //    comentario.IdFoto = id;
        //    ViewBag.IDFoto = id;
        //    Context.Comentarios.Add(comentario);
        //    return RedirectToAction("Detalles", "Foto", new { id = id });
        //}

        [HttpGet]
        [Authorize]
        public ActionResult EliminarComentario(int id)
        {
            return View(Context.Comentarios.Find(c => c.IdComentario == id));
        }

        [HttpPost, ActionName("EliminarComentario")]
        public ActionResult ConfirmarEliminar(/*Comentario comentario,*/int id)
        {
            Comentario comentario = Context.Comentarios.Find(c => c.IdComentario == id);
            //ViewBag.IDFoto = comentario.IdFoto;
            Context.Comentarios.Remove(comentario);
            return RedirectToAction("Detalles", "Foto", new { id = comentario.IdFoto });
        }

        public ActionResult EditarComentario(int id)
        {
            return View(Context.Comentarios.Find(c=>c.IdComentario== id));
        }
        [HttpPost]
        public ActionResult EditarComentario(Comentario comment)
        {
            int indice=Context.Comentarios.FindIndex(c => c.IdComentario == comment.IdComentario);
            Context.Comentarios[indice] = comment;
            return RedirectToAction("Detalles", "Foto", new { id = comment.IdFoto });
        }
    }
}