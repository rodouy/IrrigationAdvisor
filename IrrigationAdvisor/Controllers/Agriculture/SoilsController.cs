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
    public class SoilsController : Controller
    {
        private IrrigationAdvisorContext db = new IrrigationAdvisorContext();

        // GET: Soils
        public ActionResult Index()
        {
            return View(db.Soils.ToList());
        }

        // GET: Soils/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Soil soil = db.Soils.Find(id);
            if (soil == null)
            {
                return HttpNotFound();
            }
            return View(soil);
        }

        // GET: Soils/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Soils/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "SoilId,Name,Description,TestDate,DepthLimit")] Soil soil)
        {
            if (ModelState.IsValid)
            {
                db.Soils.Add(soil);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(soil);
        }

        // GET: Soils/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Soil soil = db.Soils.Find(id);
            if (soil == null)
            {
                return HttpNotFound();
            }
            return View(soil);
        }

        // POST: Soils/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "SoilId,Name,Description,TestDate,DepthLimit")] Soil soil)
        {
            if (ModelState.IsValid)
            {
                db.Entry(soil).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(soil);
        }

        // GET: Soils/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Soil soil = db.Soils.Find(id);
            if (soil == null)
            {
                return HttpNotFound();
            }
            return View(soil);
        }

        // POST: Soils/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            Soil soil = db.Soils.Find(id);
            db.Soils.Remove(soil);
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
