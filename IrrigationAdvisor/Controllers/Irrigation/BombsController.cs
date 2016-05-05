using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using IrrigationAdvisor.Models;
using IrrigationAdvisor.Models.Irrigation;

using IrrigationAdvisor.DBContext;

namespace IrrigationAdvisor.Controllers.Irrigation
{
    public class BombsController : Controller
    {
        private IrrigationAdvisorContext db = new IrrigationAdvisorContext();

        // GET: Bombs
        public ActionResult Index()
        {
            return View(db.Bombs.ToList());
        }

        // GET: Bombs/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Bomb bomb = db.Bombs.Find(id);
            if (bomb == null)
            {
                return HttpNotFound();
            }
            return View(bomb);
        }

        // GET: Bombs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Bombs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "BombId,Name,SerialNumber,ServiceDate,PurchaseDate")] Bomb bomb)
        {
            if (ModelState.IsValid)
            {
                db.Bombs.Add(bomb);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(bomb);
        }

        // GET: Bombs/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Bomb bomb = db.Bombs.Find(id);
            if (bomb == null)
            {
                return HttpNotFound();
            }
            return View(bomb);
        }

        // POST: Bombs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "BombId,Name,SerialNumber,ServiceDate,PurchaseDate")] Bomb bomb)
        {
            if (ModelState.IsValid)
            {
                db.Entry(bomb).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(bomb);
        }

        // GET: Bombs/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Bomb bomb = db.Bombs.Find(id);
            if (bomb == null)
            {
                return HttpNotFound();
            }
            return View(bomb);
        }

        // POST: Bombs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            Bomb bomb = db.Bombs.Find(id);
            db.Bombs.Remove(bomb);
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
