﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVCLoginAutenticacion.Models;

namespace MVCLoginAutenticacion.Controllers
{
    public class Order_DetailController : Controller
    {
        private NorthwindEntities db = new NorthwindEntities();

        // GET: Order_Detail
        public ActionResult Index()
        {
            var order_Details = db.Order_Details.Include(o => o.Order);
            return View(order_Details.ToList());
        }

        // GET: Order_Detail/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Order_Detail order_Detail = db.Order_Details.Find(id);
            if (order_Detail == null)
            {
                return HttpNotFound();
            }
            return View(order_Detail);
        }

        // GET: Order_Detail/Create
        public ActionResult Create()
        {
            ViewBag.OrderID = new SelectList(db.Orders, "OrderID", "CustomerID");
            return View();
        }

        // POST: Order_Detail/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "OrderID,ProductID,UnitPrice,Quantity,Discount")] Order_Detail order_Detail)
        {
            if (ModelState.IsValid)
            {
                db.Order_Details.Add(order_Detail);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.OrderID = new SelectList(db.Orders, "OrderID", "CustomerID", order_Detail.OrderID);
            return View(order_Detail);
        }

        // GET: Order_Detail/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Order_Detail order_Detail = db.Order_Details.Find(id);
            if (order_Detail == null)
            {
                return HttpNotFound();
            }
            ViewBag.OrderID = new SelectList(db.Orders, "OrderID", "CustomerID", order_Detail.OrderID);
            return View(order_Detail);
        }

        // POST: Order_Detail/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "OrderID,ProductID,UnitPrice,Quantity,Discount")] Order_Detail order_Detail)
        {
            if (ModelState.IsValid)
            {
                db.Entry(order_Detail).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.OrderID = new SelectList(db.Orders, "OrderID", "CustomerID", order_Detail.OrderID);
            return View(order_Detail);
        }

        // GET: Order_Detail/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Order_Detail order_Detail = db.Order_Details.Find(id);
            if (order_Detail == null)
            {
                return HttpNotFound();
            }
            return View(order_Detail);
        }

        // POST: Order_Detail/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Order_Detail order_Detail = db.Order_Details.Find(id);
            db.Order_Details.Remove(order_Detail);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}