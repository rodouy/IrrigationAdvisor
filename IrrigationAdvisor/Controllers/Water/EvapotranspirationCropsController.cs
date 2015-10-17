using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using IrrigationAdvisor.Models;
using IrrigationAdvisor.Models.Water;

using IrrigationAdvisor.DBContext;

namespace IrrigationAdvisor.Controllers.Water
{
    public class EvapotranspirationCropsController : Controller
    {
        private IrrigationAdvisorContext db = new IrrigationAdvisorContext();

        // GET: EvapotranspirationCrops
        public ActionResult Index()
        {
            var evapotranspirationCrops = db.EvapotranspirationCrops.Include(e => e.CropIrrigationWeather);
            return View(evapotranspirationCrops.ToList());
        }

        // GET: EvapotranspirationCrops/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EvapotranspirationCrop evapotranspirationCrop = db.EvapotranspirationCrops.Find(id);
            if (evapotranspirationCrop == null)
            {
                return HttpNotFound();
            }
            return View(evapotranspirationCrop);
        }

        // GET: EvapotranspirationCrops/Create
        public ActionResult Create()
        {
            ViewBag.CropIrrigationWeatherId = new SelectList(db.CropIrrigationWeathers, "CropIrrigationWeatherId", "OutPut");
            return View();
        }

        // POST: EvapotranspirationCrops/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "WaterOutputId,Output,Date,ExtraOutput,ExtraDate,CropIrrigationWeatherId")] EvapotranspirationCrop evapotranspirationCrop)
        {
            if (ModelState.IsValid)
            {
                db.EvapotranspirationCrops.Add(evapotranspirationCrop);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CropIrrigationWeatherId = new SelectList(db.CropIrrigationWeathers, "CropIrrigationWeatherId", "OutPut", evapotranspirationCrop.CropIrrigationWeatherId);
            return View(evapotranspirationCrop);
        }

        // GET: EvapotranspirationCrops/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EvapotranspirationCrop evapotranspirationCrop = db.EvapotranspirationCrops.Find(id);
            if (evapotranspirationCrop == null)
            {
                return HttpNotFound();
            }
            ViewBag.CropIrrigationWeatherId = new SelectList(db.CropIrrigationWeathers, "CropIrrigationWeatherId", "OutPut", evapotranspirationCrop.CropIrrigationWeatherId);
            return View(evapotranspirationCrop);
        }

        // POST: EvapotranspirationCrops/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "WaterOutputId,Output,Date,ExtraOutput,ExtraDate,CropIrrigationWeatherId")] EvapotranspirationCrop evapotranspirationCrop)
        {
            if (ModelState.IsValid)
            {
                db.Entry(evapotranspirationCrop).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CropIrrigationWeatherId = new SelectList(db.CropIrrigationWeathers, "CropIrrigationWeatherId", "OutPut", evapotranspirationCrop.CropIrrigationWeatherId);
            return View(evapotranspirationCrop);
        }

        // GET: EvapotranspirationCrops/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EvapotranspirationCrop evapotranspirationCrop = db.EvapotranspirationCrops.Find(id);
            if (evapotranspirationCrop == null)
            {
                return HttpNotFound();
            }
            return View(evapotranspirationCrop);
        }

        // POST: EvapotranspirationCrops/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            EvapotranspirationCrop evapotranspirationCrop = db.EvapotranspirationCrops.Find(id);
            db.EvapotranspirationCrops.Remove(evapotranspirationCrop);
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
