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
    public class PivotsController : Controller
    {
        private IrrigationAdvisorContext db = new IrrigationAdvisorContext();

        // GET: Pivots
        public ActionResult Index()
        {
            return View(db.Pivots.ToList());
        }

        // GET: Pivots/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pivot pivot = db.Pivots.Find(id);
            if (pivot == null)
            {
                return HttpNotFound();
            }
            return View(pivot);
        }

        // GET: Pivots/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Pivots/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IrrigationUnitId,Name,IrrigationType,IrrigationEfficiency,Surface,Radius")] Pivot pivot)
        {
            if (ModelState.IsValid)
            {
                db.Pivots.Add(pivot);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(pivot);
        }

        // GET: Pivots/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pivot pivot = db.Pivots.Find(id);
            if (pivot == null)
            {
                return HttpNotFound();
            }
            return View(pivot);
        }

        // POST: Pivots/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IrrigationUnitId,Name,IrrigationType,IrrigationEfficiency,Surface,Radius")] Pivot pivot)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pivot).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(pivot);
        }

        // GET: Pivots/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pivot pivot = db.Pivots.Find(id);
            if (pivot == null)
            {
                return HttpNotFound();
            }
            return View(pivot);
        }

        // POST: Pivots/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            Pivot pivot = db.Pivots.Find(id);
            db.Pivots.Remove(pivot);
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
