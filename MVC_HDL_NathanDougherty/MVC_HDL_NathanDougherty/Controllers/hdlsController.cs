using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVC_HDL_NathanDougherty.Models;

namespace MVC_HDL_NathanDougherty.Controllers
{
    public class hdlsController : Controller
    {
        private hdlDBContext db = new hdlDBContext();

        // GET: hdls
        public ActionResult Index()
        {
            return View(db.hdls.ToList());
        }

        // GET: hdls/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            hdl hdl = db.hdls.Find(id);
            if (hdl == null)
            {
                return HttpNotFound();
            }
            return View(hdl);
        }

        // GET: hdls/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: hdls/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Name,Bio,ImageURL,FavoriteDog,lastAte")] hdl hdl)
        {
            if (ModelState.IsValid)
            {
                db.hdls.Add(hdl);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(hdl);
        }

        // GET: hdls/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            hdl hdl = db.hdls.Find(id);
            if (hdl == null)
            {
                return HttpNotFound();
            }
            return View(hdl);
        }

        // POST: hdls/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Name,Bio,ImageURL,FavoriteDog,lastAte")] hdl hdl)
        {
            if (ModelState.IsValid)
            {
                db.Entry(hdl).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(hdl);
        }

        // GET: hdls/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            hdl hdl = db.hdls.Find(id);
            if (hdl == null)
            {
                return HttpNotFound();
            }
            return View(hdl);
        }

        // POST: hdls/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            hdl hdl = db.hdls.Find(id);
            db.hdls.Remove(hdl);
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
