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
    public class CropInformationByDatesController : Controller
    {
        private IrrigationAdvisorContext db = new IrrigationAdvisorContext();

        // GET: CropInformationByDates
        public ActionResult Index()
        {
            return View(db.CropInformationByDates.ToList());
        }

        // GET: CropInformationByDates/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CropInformationByDate cropInformationByDate = db.CropInformationByDates.Find(id);
            if (cropInformationByDate == null)
            {
                return HttpNotFound();
            }
            return View(cropInformationByDate);
        }

        // GET: CropInformationByDates/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CropInformationByDates/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CropInformationByDateId,SowingDate,CurrentDate,DaysAfterSowing,AccumulatedGrowingDegreeDays,CropCoefficientValue,RootDepth")] CropInformationByDate cropInformationByDate)
        {
            if (ModelState.IsValid)
            {
                db.CropInformationByDates.Add(cropInformationByDate);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cropInformationByDate);
        }

        // GET: CropInformationByDates/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CropInformationByDate cropInformationByDate = db.CropInformationByDates.Find(id);
            if (cropInformationByDate == null)
            {
                return HttpNotFound();
            }
            return View(cropInformationByDate);
        }

        // POST: CropInformationByDates/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CropInformationByDateId,SowingDate,CurrentDate,DaysAfterSowing,AccumulatedGrowingDegreeDays,CropCoefficientValue,RootDepth")] CropInformationByDate cropInformationByDate)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cropInformationByDate).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cropInformationByDate);
        }

        // GET: CropInformationByDates/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CropInformationByDate cropInformationByDate = db.CropInformationByDates.Find(id);
            if (cropInformationByDate == null)
            {
                return HttpNotFound();
            }
            return View(cropInformationByDate);
        }

        // POST: CropInformationByDates/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            CropInformationByDate cropInformationByDate = db.CropInformationByDates.Find(id);
            db.CropInformationByDates.Remove(cropInformationByDate);
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
