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
    public class CropIrrigationWeathersController : Controller
    {
        private IrrigationAdvisorContext db = new IrrigationAdvisorContext();

        // GET: CropIrrigationWeathers
        public ActionResult Index()
        {
            return View(db.CropIrrigationWeathers.ToList());
        }

        // GET: CropIrrigationWeathers/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CropIrrigationWeather cropIrrigationWeather = db.CropIrrigationWeathers.Find(id);
            if (cropIrrigationWeather == null)
            {
                return HttpNotFound();
            }
            return View(cropIrrigationWeather);
        }

        // GET: CropIrrigationWeathers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CropIrrigationWeathers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CropIrrigationWeatherId,SowingDate,HarvestDate,CropDate,HydricBalance,SoilHydricVolume,TotalEvapotranspirationCropFromLastWaterInput,DaysAfterSowing,DaysAfterSowingModified,GrowingDegreeDaysAccumulated,GrowingDegreeDaysModified,PredeterminatedIrrigationQuantity,LastWaterInputDate,LastBigWaterInputDate,LastPartialWaterInputDate,LastPartialWaterInput,UsingMainWeatherStation,TotalEvapotranspirationCrop,TotalEffectiveRain,TotalRealRain,TotalIrrigation,TotalIrrigationInHydricBalance,TotalExtraIrrigation,TotalExtraIrrigationInHydricBalance,OutPut")] CropIrrigationWeather cropIrrigationWeather)
        {
            if (ModelState.IsValid)
            {
                db.CropIrrigationWeathers.Add(cropIrrigationWeather);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cropIrrigationWeather);
        }

        // GET: CropIrrigationWeathers/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CropIrrigationWeather cropIrrigationWeather = db.CropIrrigationWeathers.Find(id);
            if (cropIrrigationWeather == null)
            {
                return HttpNotFound();
            }
            return View(cropIrrigationWeather);
        }

        // POST: CropIrrigationWeathers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CropIrrigationWeatherId,SowingDate,HarvestDate,CropDate,HydricBalance,SoilHydricVolume,TotalEvapotranspirationCropFromLastWaterInput,DaysAfterSowing,DaysAfterSowingModified,GrowingDegreeDaysAccumulated,GrowingDegreeDaysModified,PredeterminatedIrrigationQuantity,LastWaterInputDate,LastBigWaterInputDate,LastPartialWaterInputDate,LastPartialWaterInput,UsingMainWeatherStation,TotalEvapotranspirationCrop,TotalEffectiveRain,TotalRealRain,TotalIrrigation,TotalIrrigationInHydricBalance,TotalExtraIrrigation,TotalExtraIrrigationInHydricBalance,OutPut")] CropIrrigationWeather cropIrrigationWeather)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cropIrrigationWeather).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cropIrrigationWeather);
        }

        // GET: CropIrrigationWeathers/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CropIrrigationWeather cropIrrigationWeather = db.CropIrrigationWeathers.Find(id);
            if (cropIrrigationWeather == null)
            {
                return HttpNotFound();
            }
            return View(cropIrrigationWeather);
        }

        // POST: CropIrrigationWeathers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            CropIrrigationWeather cropIrrigationWeather = db.CropIrrigationWeathers.Find(id);
            db.CropIrrigationWeathers.Remove(cropIrrigationWeather);
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
