using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using IrrigationAdvisor.Models;
using IrrigationAdvisor.Models.Agriculture;

using IrrigationAdvisor.DBContext;

namespace IrrigationAdvisor.Controllers.Agriculture
{
    public class SpecieCyclesController : Controller
    {
        private IrrigationAdvisorContext db = new IrrigationAdvisorContext();

        // GET: SpecieCycles
        public ActionResult Index()
        {
            return View(db.SpecieCycles.ToList());
        }

        // GET: SpecieCycles/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SpecieCycle specieCycle = db.SpecieCycles.Find(id);
            if (specieCycle == null)
            {
                return HttpNotFound();
            }
            return View(specieCycle);
        }

        // GET: SpecieCycles/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SpecieCycles/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "SpecieCycleId,Name,Duration")] SpecieCycle specieCycle)
        {
            if (ModelState.IsValid)
            {
                db.SpecieCycles.Add(specieCycle);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(specieCycle);
        }

        // GET: SpecieCycles/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SpecieCycle specieCycle = db.SpecieCycles.Find(id);
            if (specieCycle == null)
            {
                return HttpNotFound();
            }
            return View(specieCycle);
        }

        // POST: SpecieCycles/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "SpecieCycleId,Name,Duration")] SpecieCycle specieCycle)
        {
            if (ModelState.IsValid)
            {
                db.Entry(specieCycle).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(specieCycle);
        }

        // GET: SpecieCycles/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SpecieCycle specieCycle = db.SpecieCycles.Find(id);
            if (specieCycle == null)
            {
                return HttpNotFound();
            }
            return View(specieCycle);
        }

        // POST: SpecieCycles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            SpecieCycle specieCycle = db.SpecieCycles.Find(id);
            db.SpecieCycles.Remove(specieCycle);
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
