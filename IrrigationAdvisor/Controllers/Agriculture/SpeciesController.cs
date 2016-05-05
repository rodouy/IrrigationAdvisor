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
    public class SpeciesController : Controller
    {
        private IrrigationAdvisorContext db = new IrrigationAdvisorContext();

        // GET: Species
        public ActionResult Index()
        {
            var species = db.Species.Include(s => s.SpecieCycle);
            return View(species.ToList());
        }

        // GET: Species/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Specie specie = db.Species.Find(id);
            if (specie == null)
            {
                return HttpNotFound();
            }
            return View(specie);
        }

        // GET: Species/Create
        public ActionResult Create()
        {
            ViewBag.SpecieCycleId = new SelectList(db.SpecieCycles, "SpecieCycleId", "Name");
            return View();
        }

        // POST: Species/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "SpecieId,Name,SpecieCycleId,BaseTemperature,StressTemperature")] Specie specie)
        {
            if (ModelState.IsValid)
            {
                db.Species.Add(specie);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.SpecieCycleId = new SelectList(db.SpecieCycles, "SpecieCycleId", "Name", specie.SpecieCycleId);
            return View(specie);
        }

        // GET: Species/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Specie specie = db.Species.Find(id);
            if (specie == null)
            {
                return HttpNotFound();
            }
            ViewBag.SpecieCycleId = new SelectList(db.SpecieCycles, "SpecieCycleId", "Name", specie.SpecieCycleId);
            return View(specie);
        }

        // POST: Species/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "SpecieId,Name,SpecieCycleId,BaseTemperature,StressTemperature")] Specie specie)
        {
            if (ModelState.IsValid)
            {
                db.Entry(specie).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.SpecieCycleId = new SelectList(db.SpecieCycles, "SpecieCycleId", "Name", specie.SpecieCycleId);
            return View(specie);
        }

        // GET: Species/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Specie specie = db.Species.Find(id);
            if (specie == null)
            {
                return HttpNotFound();
            }
            return View(specie);
        }

        // POST: Species/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            Specie specie = db.Species.Find(id);
            db.Species.Remove(specie);
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
