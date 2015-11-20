using OperaMVC2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OperaMVC2.Controllers
{
    public class CantanteController : Controller
    {
        //CantanteContex DBContexCantante = new CantanteContex(); 
        // GET: Cantante
        public ActionResult Index()
        {
            return View(CantanteContex.Cantantes);
        }

        public ActionResult Details(int id)
        {
            Cantante cantante = (from c in CantanteContex.Cantantes
                                 where c.Id == id
                                 select c).First<Cantante>();
            return View(cantante);
        }

        public ActionResult Edit(int id)
        {
            //Cantante cantante = (from c in CantanteContex.Cantantes
            //                     where c.Id == id
            //                     select c).First<Cantante>();
            return View(CantanteContex.Cantantes.Find(c => c.Id == id));
        }

        [HttpPost]
        public ActionResult Edit(Cantante cantante)
        {
            //DE ESTA MANERA TAMBIEN FUNCIONA
            //if (ModelState.IsValid)
            //{
            //    var elCantante = CantanteContex.Cantantes.Find(c => c.Id == cantante.Id);
            //    elCantante.Nombre = cantante.Nombre;
            //    elCantante.Voz = cantante.Voz;
            //    elCantante.Id = cantante.Id;
            //    return RedirectToAction("Index");
            //}
            //else
            //{
            //    return RedirectToAction("Error");
            //}
            int index = CantanteContex.Cantantes.FindIndex(c => c.Id == cantante.Id);
            if ((CantanteContex.Cantantes[index] != null) && (ModelState.IsValid))
            {
                CantanteContex.Cantantes[index] = cantante;
                return RedirectToAction("Index");
            }
            else
            {
                return RedirectToAction("Error");
            }
        }

        public ActionResult Create()
        {
            return View(new Cantante()
            {
                Id = CantanteContex.Cantantes.Count + 1,
                //envio el Id desde aqui y en la vista lo regreso con un inputHidden
                //lo hago solo para aprender pero no se deben mostrar datos que al usuario no le importen
                Nombre = "",
                Voz = ""
            });
        }

        [HttpPost]
        public ActionResult Create(Cantante cantante)
        {
            if (ModelState.IsValid)//Valida el formulario y si todo va bien entonces sigue
            {
                //AQUI ES DONDE DEBE ASIGNARSE Y CREARSE EL ID PARA ALMACENARLO LUEGO
                //cantante.Id = CantanteContex.Cantantes.Count+1;
                CantanteContex.Cantantes.Add(cantante);
                //new Cantante()
                //{
                //    Id = CantanteContex.Cantantes.Count,
                //    Nombre = Nombre,
                //    Voz = Voz
                //});
                return RedirectToAction("Index");
            }
            else
            {
                return View("Create", cantante);
            }

        }

        public ActionResult Delete(int Id)
        {
            return View(CantanteContex.Cantantes.Find(c => c.Id == Id));
        }

        [HttpPost]
        public ActionResult Delete(int? Id)
        {
            if (CantanteContex.Cantantes.RemoveAll(c => c.Id == Id) > 0)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return RedirectToAction("Error");
            }

        }

        public ActionResult Error()
        {
            return View();
        }
    }
}