using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCNorthwinnd.Models;

namespace MVCNorthwinnd.Controllers
{
    public class PedidosController : Controller
    {
        NorthwindEntities DBContext = new NorthwindEntities();
        // GET: Pedidos
        public ActionResult Index()
        {
            return View(DBContext.Orders.ToList());
        }

        public ActionResult Details(int id)
        {
            return View((from o in DBContext.Order_Details where o.OrderID == id select o).FirstOrDefault());
        }

        [ChildActionOnly]
        public PartialViewResult _OrdersByCustomer()
        {
            return PartialView();
        }


        [HttpPost]
        public PartialViewResult _OrdersByCustomer(string id/*FormCollection form*/)
        {
            //string id = form["id"].ToString();
            ViewBag.compania = DBContext.Customers.Find(id).CompanyName;
            List<Order> pedidos = (from o in DBContext.Orders where o.Customer.CustomerID == id select o).ToList<Order>();
            return PartialView(pedidos);
        }
      
    }
}