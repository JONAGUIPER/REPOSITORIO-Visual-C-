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

        public ActionResult AgregarComentario(int? IDFoto)
        {
            if (IDFoto!=null)
            {
                Comentario coment = new Comentario();
                coment.FotoId = IDFoto.GetValueOrDefault();
                return View(coment);
            }
            else
            {
                return View("Index");
            }
      
        }
        [HttpPost]
        public ActionResult AgregarComentario(Comentario comentario)
        {
            if (ModelState.IsValid)
            {
                comentario.IdComentario = DbContext.Comentarios.Max().IdComentario + 1;
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
        public ActionResult _Comentarios(int IDFoto)
        {
            List<Comentario> RComentarios = DbContext.Comentarios.FindAll(f => f.FotoId == IDFoto);
            return View(RComentarios);
        }
    }
}