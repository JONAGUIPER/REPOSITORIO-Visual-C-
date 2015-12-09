using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Nobel.Models;

namespace MVC_Nobel.Controllers
{
    public class ComentarioController : Controller
    {
        // GET: Comentario
        public PartialViewResult _ComentariosDeFoto(int id)
        {
            List<Comentario> Comentarios = (from c in Context.Comentarios
                                            where c.fotoID==id
                                            select c).ToList<Comentario>();
            ViewBag.idFoto = id;
            return PartialView("_ComentariosDeFoto", Comentarios);
        }

        [HttpPost]
        public PartialViewResult _ComentariosDeFoto(Comentario comentario, int id)
        {
            int idSiguiente = Context.Comentarios.Max(c => c.comentarioID) + 1;
            comentario.comentarioID = idSiguiente;
            comentario.fotoID = id;
            Context.Comentarios.Add(comentario);
           
            List<Comentario> comentarios = (from c in Context.Comentarios
                                            where c.fotoID == id
                                            select c).ToList<Comentario>();
            ViewBag.idFoto = id;
            return PartialView("_ComentariosDeFoto", comentarios);
        }
        public PartialViewResult _Create(int id)
        {
            Comentario comentario = new Comentario();
            comentario.fotoID = id;
            ViewBag.idFoto = id;
            return PartialView("_CreateAComment", comentario);
        }

        public ActionResult Delete(int id = 0)
        {
            Comentario commentario = Context.Comentarios.Find(c => c.comentarioID==id);
            
            if (commentario == null)
            {
                return HttpNotFound();
            }
            ViewBag.idFoto = commentario.fotoID;
            return View(commentario);
        }

        //
        // POST: /Comment/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Comentario commentario = Context.Comentarios.Find(c => c.comentarioID == id);
            Context.Comentarios.Remove(commentario);
            
            return RedirectToAction("Detalles", "Foto", new { id = commentario.fotoID });
        }
    }
}