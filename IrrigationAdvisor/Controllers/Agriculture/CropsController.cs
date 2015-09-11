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
    public class CropsController : Controller
    {
        private IrrigationAdvisorContext db = new IrrigationAdvisorContext();

        // GET: Crops
        public ActionResult Index()
        {
            var crops = db.Crops.Include(c => c.Region).Include(c => c.Specie);
            return View(crops.ToList());
        }

        // GET: Crops/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Crop crop = db.Crops.Find(id);
            if (crop == null)
            {
                return HttpNotFound();
            }
            return View(crop);
        }

        // GET: Crops/Create
        public ActionResult Create()
        {
            ViewBag.RegionId = new SelectList(db.Regions, "RegionId", "Name");
            ViewBag.SpecieId = new SelectList(db.Species, "SpecieId", "Name");
            return View();
        }

        // POST: Crops/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CropId,Name,RegionId,SpecieId,Density,MaxEvapotranspirationToIrrigate,MinEvapotranspirationToIrrigate")] Crop crop)
        {
            if (ModelState.IsValid)
            {
                db.Crops.Add(crop);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.RegionId = new SelectList(db.Regions, "RegionId", "Name", crop.RegionId);
            ViewBag.SpecieId = new SelectList(db.Species, "SpecieId", "Name", crop.SpecieId);
            return View(crop);
        }

        // GET: Crops/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Crop crop = db.Crops.Find(id);
            if (crop == null)
            {
                return HttpNotFound();
            }
            ViewBag.RegionId = new SelectList(db.Regions, "RegionId", "Name", crop.RegionId);
            ViewBag.SpecieId = new SelectList(db.Species, "SpecieId", "Name", crop.SpecieId);
            return View(crop);
        }

        // POST: Crops/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CropId,Name,RegionId,SpecieId,Density,MaxEvapotranspirationToIrrigate,MinEvapotranspirationToIrrigate")] Crop crop)
        {
            if (ModelState.IsValid)
            {
                db.Entry(crop).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.RegionId = new SelectList(db.Regions, "RegionId", "Name", crop.RegionId);
            ViewBag.SpecieId = new SelectList(db.Species, "SpecieId", "Name", crop.SpecieId);
            return View(crop);
        }

        // GET: Crops/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Crop crop = db.Crops.Find(id);
            if (crop == null)
            {
                return HttpNotFound();
            }
            return View(crop);
        }

        // POST: Crops/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            Crop crop = db.Crops.Find(id);
            db.Crops.Remove(crop);
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
