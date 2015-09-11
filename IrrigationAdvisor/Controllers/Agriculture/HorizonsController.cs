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
    public class HorizonsController : Controller
    {
        private IrrigationAdvisorContext db = new IrrigationAdvisorContext();

        // GET: Horizons
        public ActionResult Index()
        {
            return View(db.Horizons.ToList());
        }

        // GET: Horizons/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Horizon horizon = db.Horizons.Find(id);
            if (horizon == null)
            {
                return HttpNotFound();
            }
            return View(horizon);
        }

        // GET: Horizons/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Horizons/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "HorizonId,Name,Order,HorizonLayer,HorizonLayerDepth,Sand,Limo,Clay,OrganicMatter,NitrogenAnalysis,BulkDensitySoil")] Horizon horizon)
        {
            if (ModelState.IsValid)
            {
                db.Horizons.Add(horizon);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(horizon);
        }

        // GET: Horizons/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Horizon horizon = db.Horizons.Find(id);
            if (horizon == null)
            {
                return HttpNotFound();
            }
            return View(horizon);
        }

        // POST: Horizons/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "HorizonId,Name,Order,HorizonLayer,HorizonLayerDepth,Sand,Limo,Clay,OrganicMatter,NitrogenAnalysis,BulkDensitySoil")] Horizon horizon)
        {
            if (ModelState.IsValid)
            {
                db.Entry(horizon).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(horizon);
        }

        // GET: Horizons/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Horizon horizon = db.Horizons.Find(id);
            if (horizon == null)
            {
                return HttpNotFound();
            }
            return View(horizon);
        }

        // POST: Horizons/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            Horizon horizon = db.Horizons.Find(id);
            db.Horizons.Remove(horizon);
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
