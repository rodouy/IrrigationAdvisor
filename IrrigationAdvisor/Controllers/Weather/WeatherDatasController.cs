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
    public class WeatherDatasController : Controller
    {
        private IrrigationAdvisorContext db = new IrrigationAdvisorContext();

        // GET: WeatherDatas
        public ActionResult Index()
        {
            return View(db.WeatherDatas.ToList());
        }

        // GET: WeatherDatas/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WeatherData weatherData = db.WeatherDatas.Find(id);
            if (weatherData == null)
            {
                return HttpNotFound();
            }
            return View(weatherData);
        }

        // GET: WeatherDatas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: WeatherDatas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "WeatherDataId,Date,Temperature,TemperatureMax,TemperatureMin,TemperatureDewPoint,Humidity,HumidityMax,HumidityMin,Barometer,BarometerMax,BarometerMin,SolarRadiation,UVRadiation,RainDay,RainStorm,RainMonth,RainYear,Evapotranspiration,EvapotranspirationMonth,EvapotranspirationYear,WeatherDataType")] WeatherData weatherData)
        {
            if (ModelState.IsValid)
            {
                db.WeatherDatas.Add(weatherData);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(weatherData);
        }

        // GET: WeatherDatas/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WeatherData weatherData = db.WeatherDatas.Find(id);
            if (weatherData == null)
            {
                return HttpNotFound();
            }
            return View(weatherData);
        }

        // POST: WeatherDatas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "WeatherDataId,Date,Temperature,TemperatureMax,TemperatureMin,TemperatureDewPoint,Humidity,HumidityMax,HumidityMin,Barometer,BarometerMax,BarometerMin,SolarRadiation,UVRadiation,RainDay,RainStorm,RainMonth,RainYear,Evapotranspiration,EvapotranspirationMonth,EvapotranspirationYear,WeatherDataType")] WeatherData weatherData)
        {
            if (ModelState.IsValid)
            {
                db.Entry(weatherData).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(weatherData);
        }

        // GET: WeatherDatas/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WeatherData weatherData = db.WeatherDatas.Find(id);
            if (weatherData == null)
            {
                return HttpNotFound();
            }
            return View(weatherData);
        }

        // POST: WeatherDatas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            WeatherData weatherData = db.WeatherDatas.Find(id);
            db.WeatherDatas.Remove(weatherData);
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
