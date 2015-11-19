using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FirstMVC.Models;

namespace FirstMVC.Controllers
{
    public class ClientesController : Controller
    {
        NorthwindEntities ContextoDB = new NorthwindEntities();
        // GET: Clientes
        public ActionResult Index()
        {

            List<Customer> clientes = (from c in ContextoDB.Customers select c).ToList<Customer>();
            //List<Customer> clientes = new List<Customer>();
            //foreach (var item in resultado)
            //{
            //    clientes.Add(item);
            //}
            return View(clientes);
        }

        public ActionResult Details(string Id)
        {
            if (string.IsNullOrEmpty(Id))
            {
                //return RedirectToAction("Index","Home");
                return RedirectToAction("Error");

            }
            else
            {
                Customer cliente = new Customer();
                cliente = (from c in ContextoDB.Customers
                           where c.CustomerID == Id
                           select c).First<Customer>();
                //cliente=ContextoDB.Customers.Find(Id);
                return View(cliente);
            }
        }

        public ActionResult Edit(string id)
        {
            
            return View(ContextoDB.Customers.Find(id));
        }

        [HttpPost]
        public ActionResult Edit(string id, string CompanyName, string ContactName,
            string ContactTitle, string Address,string City, string Region, string PostalCode,
            string Country, string Phone, string Fax)
        {
            Customer cliente = ContextoDB.Customers.Find(id);
            cliente.CompanyName = CompanyName;
            cliente.ContactName = ContactName;
            cliente.ContactTitle = ContactTitle;
            cliente.Address = Address;
            cliente.City = City;
            cliente.Region = Region;
            cliente.PostalCode = PostalCode;
            cliente.Country = Country;
            cliente.Phone = Phone;
            cliente.Fax = Fax;
            ContextoDB.Entry(cliente).State = System.Data.Entity.EntityState.Modified;
            ContextoDB.SaveChanges();
            return View(ContextoDB.Customers.Find(id));
        }

        public ActionResult Error()
        {
            return View();
        }
    }
}