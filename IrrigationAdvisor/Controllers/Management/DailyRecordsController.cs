using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using IrrigationAdvisor.Models;
using IrrigationAdvisor.Models.Management;

using IrrigationAdvisor.DBContext;

namespace IrrigationAdvisor.Controllers.Management
{
    public class DailyRecordsController : Controller
    {
        private IrrigationAdvisorContext db = new IrrigationAdvisorContext();

        // GET: DailyRecords
        public ActionResult Index()
        {
            return View(db.DailyRecords.ToList());
        }

        // GET: DailyRecords/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DailyRecord dailyRecord = db.DailyRecords.Find(id);
            if (dailyRecord == null)
            {
                return HttpNotFound();
            }
            return View(dailyRecord);
        }

        // GET: DailyRecords/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DailyRecords/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "DailyRecordId,DailyRecordDateTime,DaysAfterSowing,DaysAfterSowingModified,GrowingDegreeDays,GrowingDegreeDaysAccumulated,GrowingDegreeDaysModified,LastWaterInputDate,LastBigWaterInputDate,LastPartialWaterInputDate,LastPartialWaterInput,HydricBalance,SoilHydricVolume,TotalEvapotranspirationCropFromLastWaterInput,CropCoefficient,Observations,TotalEvapotranspirationCrop,TotalEffectiveRain,TotalRealRain,TotalIrrigation,TotalIrrigationInHydricBalance,TotalExtraIrrigation,TotalExtraIrrigationInHidricBalance")] DailyRecord dailyRecord)
        {
            if (ModelState.IsValid)
            {
                db.DailyRecords.Add(dailyRecord);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(dailyRecord);
        }

        // GET: DailyRecords/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DailyRecord dailyRecord = db.DailyRecords.Find(id);
            if (dailyRecord == null)
            {
                return HttpNotFound();
            }
            return View(dailyRecord);
        }

        // POST: DailyRecords/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "DailyRecordId,DailyRecordDateTime,DaysAfterSowing,DaysAfterSowingModified,GrowingDegreeDays,GrowingDegreeDaysAccumulated,GrowingDegreeDaysModified,LastWaterInputDate,LastBigWaterInputDate,LastPartialWaterInputDate,LastPartialWaterInput,HydricBalance,SoilHydricVolume,TotalEvapotranspirationCropFromLastWaterInput,CropCoefficient,Observations,TotalEvapotranspirationCrop,TotalEffectiveRain,TotalRealRain,TotalIrrigation,TotalIrrigationInHydricBalance,TotalExtraIrrigation,TotalExtraIrrigationInHidricBalance")] DailyRecord dailyRecord)
        {
            if (ModelState.IsValid)
            {
                db.Entry(dailyRecord).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(dailyRecord);
        }

        // GET: DailyRecords/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DailyRecord dailyRecord = db.DailyRecords.Find(id);
            if (dailyRecord == null)
            {
                return HttpNotFound();
            }
            return View(dailyRecord);
        }

        // POST: DailyRecords/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            DailyRecord dailyRecord = db.DailyRecords.Find(id);
            db.DailyRecords.Remove(dailyRecord);
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
