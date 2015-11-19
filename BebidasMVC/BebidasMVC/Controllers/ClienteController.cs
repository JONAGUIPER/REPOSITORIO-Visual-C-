using BebidasMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BebidasMVC.Controllers
{
    public class ClienteController : Controller
    {
        //DBContex dbContext = new DBContex();
        // GET: Cliente
        public ActionResult Index()
        {
            List<Cliente> clientes = (from c in DBContex.clientes select c).ToList<Cliente>();
            return View(clientes);
        }

        // GET: Cliente/Details/5
        public ActionResult Details(int id)
        {
            Cliente cliente = (from c in DBContex.clientes where c.idCuenta==id select c).First<Cliente>();
            return View(cliente);
        }

        // GET: Cliente/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Cliente/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                DBContex.clientes.Add(new Cliente()
                {
                    idCuenta = Convert.ToInt32(collection.GetValues("idCuenta")[0]),
                    nombre=collection.GetValues("nombre")[0].ToString(),
                    apellidos=collection.GetValues("apellidos")[0].ToString(),
                    edad= Convert.ToInt32(collection.GetValues("edad")[0]),
                    telefono = collection.GetValues("telefono")[0].ToString(),
                    email = collection.GetValues("email")[0].ToString()
                });
                
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch(Exception ex)
            {
                return View();
            }
        }

        // GET: Cliente/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Cliente/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Cliente/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Cliente/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
