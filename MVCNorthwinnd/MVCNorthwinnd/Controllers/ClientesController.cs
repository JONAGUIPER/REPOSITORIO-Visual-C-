using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCNorthwinnd.Models;

namespace MVCNorthwinnd.Controllers
{
    public class ClientesController : Controller
    {
        NorthwindEntities DbContext = new NorthwindEntities();
        // GET: Clientes
        public ActionResult Index()
        {
            return View(DbContext.Customers.ToList<Customer>());
        }

        public ActionResult Details(string id)
        {
            return View((from c in DbContext.Customers where c.CustomerID == id select c).FirstOrDefault());
        }

        public ActionResult PedidosCompania()
        {
            return View((from compa in DbContext.Customers where compa.Orders.Count>0 select compa).ToList<Customer>());
        }
    }
}