using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using IrrigationAdvisor.Models;
using IrrigationAdvisor.Models.Weather;

using IrrigationAdvisor.DBContext;

namespace IrrigationAdvisor.Controllers.Weather
{
    public class WeatherStationsController : Controller
    {
        private IrrigationAdvisorContext db = new IrrigationAdvisorContext();

        // GET: WeatherStations
        public ActionResult Index()
        {
            return View(db.WeatherStations.ToList());
        }

        // GET: WeatherStations/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WeatherStation weatherStation = db.WeatherStations.Find(id);
            if (weatherStation == null)
            {
                return HttpNotFound();
            }
            return View(weatherStation);
        }

        // GET: WeatherStations/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: WeatherStations/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "WeatherStationId,Name,Model,DateOfInstallation,DateOfService,UpdateTime,WirelessTransmission,GiveET,WeatherDataType")] WeatherStation weatherStation)
        {
            if (ModelState.IsValid)
            {
                db.WeatherStations.Add(weatherStation);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(weatherStation);
        }

        // GET: WeatherStations/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WeatherStation weatherStation = db.WeatherStations.Find(id);
            if (weatherStation == null)
            {
                return HttpNotFound();
            }
            return View(weatherStation);
        }

        // POST: WeatherStations/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "WeatherStationId,Name,Model,DateOfInstallation,DateOfService,UpdateTime,WirelessTransmission,GiveET,WeatherDataType")] WeatherStation weatherStation)
        {
            if (ModelState.IsValid)
            {
                db.Entry(weatherStation).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(weatherStation);
        }

        // GET: WeatherStations/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WeatherStation weatherStation = db.WeatherStations.Find(id);
            if (weatherStation == null)
            {
                return HttpNotFound();
            }
            return View(weatherStation);
        }

        // POST: WeatherStations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            WeatherStation weatherStation = db.WeatherStations.Find(id);
            db.WeatherStations.Remove(weatherStation);
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
