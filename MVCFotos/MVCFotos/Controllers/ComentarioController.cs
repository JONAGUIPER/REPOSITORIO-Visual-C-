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
                return RedirectToAction("Index", DbContext.Fotos);
            }

        }
        [HttpPost]
        public ActionResult AgregarComentario(Comentario comentario)
        {
            if (ModelState.IsValid)
            {
                comentario.IdComentario = DbContext.Comentarios.Max(f => f.IdComentario) + 1;
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
        [AcceptVerbs(HttpVerbs.Delete)]
        public PartialViewResult Delete(int id, int idfoto)
        {
            Comentario comment = (from c in DbContext.Comentarios where c.IdComentario == id select c).FirstOrDefault();
            if (comment != null)
            {
                DbContext.Comentarios.Remove(comment);
            }
            ViewBag.idFoto = idfoto;
            List<Comentario> comentarios = (from c in DbContext.Comentarios where c.FotoId == idfoto select c).ToList();
            return PartialView("_Comentarios", comentarios);
            //return RedirectToAction("Details", "Foto", new { id = comment.FotoId });
        }

        [ChildActionOnly]
        public PartialViewResult _Comentarios(int IDFoto)
        {
            ViewBag.idFoto = IDFoto;
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
        public PartialViewResult _AgregarComentario2(Comentario comentario)
        {
            int idnuevo = DbContext.Comentarios.Max(f => f.IdComentario) + 1;
            comentario.IdComentario = idnuevo;
            int idfoto = comentario.FotoId;
            comentario.FechaCreacion = DateTime.Now;
            if (DbContext.Comentarios.FindAll(c => c.IdComentario == idnuevo).Count == 0)
            {
                DbContext.Comentarios.Add(comentario);
                DbContext.Fotos.Find(f => f.IDFoto == idfoto).Comentarios.Add(comentario);
            }

            //List<Comentario> ComentariosPhoto = (from fc in DbContext.Comentarios where fc.FotoId == idfoto select fc).ToList();
            return PartialView("_Comentario", /*ComentariosPhoto*/DbContext.Fotos.Find(f => f.IDFoto == idfoto).Comentarios);
        }

        //[HttpPost]
        //public ActionResult _AgregarComentario(Comentario comentario)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        comentario.IdComentario = DbContext.Comentarios.Max(f => f.IdComentario) + 1;
        //        comentario.FechaCreacion = DateTime.Now;
        //        DbContext.Comentarios.Add(comentario);
        //        Foto photo = (from f in DbContext.Fotos where f.IDFoto == comentario.FotoId select f).First<Foto>();
        //        return RedirectToAction("Details", "Foto", photo);
        //    }
        //    else
        //    {
        //        return View();
        //    }
        //}

        /*********************VIENE DE LOS EJEMPLOS**********/


        [ChildActionOnly]
        public PartialViewResult _CommentsForPhoto(int id)
        {
            List<Comentario> comentarios = (from c in DbContext.Comentarios where c.FotoId == id select c).ToList();
            ViewBag.idFoto = id;
            return PartialView(comentarios);
        }



        public PartialViewResult _Create(int id)
        {
            Comentario comment = new Comentario() { FotoId = id };
            ViewBag.idFoto = id;
            return PartialView("_CreateAComment");
        }

        [HttpPost]
        public PartialViewResult _CommentsForPhoto(Comentario comment)
        {
            comment.FechaCreacion = DateTime.Now;
            DbContext.Fotos.Find(c => c.IDFoto == comment.FotoId).Comentarios.Add(comment);
            DbContext.Comentarios.Add(comment);
            ViewBag.idFoto = comment.FotoId;
            List<Comentario> comentarios = (from c in DbContext.Comentarios where c.FotoId == comment.FotoId select c).ToList();
            return PartialView("_CommentsForPhotoAjax", comentarios);
        }



        [ChildActionOnly]
        public PartialViewResult _CommentsForPhotoAjax(int id)
        {
            List<Comentario> comentarios = (from c in DbContext.Comentarios where c.FotoId == id select c).ToList();
            ViewBag.idFoto = id;
            return PartialView("_CommentsForPhotoAjax", comentarios);
        }
        [HttpPost]
        public PartialViewResult _CommentsForPhotoAjax(Comentario comment)
        {
            comment.FechaCreacion = DateTime.Now;
            DbContext.Fotos.Find(c => c.IDFoto == comment.FotoId).Comentarios.Add(comment);
            DbContext.Comentarios.Add(comment);
            ViewBag.idFoto = comment.FotoId;
            List<Comentario> comentarios = (from c in DbContext.Comentarios where c.FotoId == comment.FotoId select c).ToList();
            return PartialView("_CommentsForPhotoAjax", comentarios);
        }
        [HttpGet]
        [ChildActionOnly]
        public ActionResult _AgregarComentarioAjax(int? id)
        {
            if (id != null)
            {
                Comentario coment = new Comentario();
                coment.FotoId = id.GetValueOrDefault();
                ViewBag.NFoto = DbContext.Fotos.Find(f => f.IDFoto == id).Titulo;
                return PartialView("_CreateAComment",coment);
            }
            else
            {
                return RedirectToAction("Index", DbContext.Fotos);
            }

        }

        [HttpPost,ActionName("Guardar")]
        public ActionResult AgregarComentarioAjax(Comentario comentario)
        {
            if (ModelState.IsValid)
            {
                comentario.IdComentario = DbContext.Comentarios.Max(f => f.IdComentario) + 1;
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

        public ActionResult DeleteAjax(int id = 0)
        {
            Comentario comment = DbContext.Comentarios.Find(c => c.IdComentario == id);
            ViewBag.PhotoID = comment.FotoId;
            if (comment == null)
            {
                return HttpNotFound();
            }
            return View(comment);
        }

        //
        // POST: /Comment/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Comentario comment = DbContext.Comentarios.Find(c => c.IdComentario == id);
            DbContext.Comentarios.Remove(comment);
            return RedirectToAction("Details", "Foto", new { id = comment.FotoId });
        }


    }
}