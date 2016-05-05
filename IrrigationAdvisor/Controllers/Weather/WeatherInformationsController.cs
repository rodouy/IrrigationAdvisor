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
    public class WeatherInformationsController : Controller
    {
        private IrrigationAdvisorContext db = new IrrigationAdvisorContext();

        // GET: WeatherInformations
        public ActionResult Index()
        {
            var weatherInformations = db.WeatherInformations.Include(w => w.WeatherData);
            return View(weatherInformations.ToList());
        }

        // GET: WeatherInformations/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WeatherInformation weatherInformation = db.WeatherInformations.Find(id);
            if (weatherInformation == null)
            {
                return HttpNotFound();
            }
            return View(weatherInformation);
        }

        // GET: WeatherInformations/Create
        public ActionResult Create()
        {
            ViewBag.WeatherDataId = new SelectList(db.WeatherDatas, "WeatherDataId", "WeatherDataId");
            return View();
        }

        // POST: WeatherInformations/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "WeatherInformationId,WebAddress,WebData,RequestData,ResponseData,WeatherDataId")] WeatherInformation weatherInformation)
        {
            if (ModelState.IsValid)
            {
                db.WeatherInformations.Add(weatherInformation);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.WeatherDataId = new SelectList(db.WeatherDatas, "WeatherDataId", "WeatherDataId", weatherInformation.WeatherDataId);
            return View(weatherInformation);
        }

        // GET: WeatherInformations/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WeatherInformation weatherInformation = db.WeatherInformations.Find(id);
            if (weatherInformation == null)
            {
                return HttpNotFound();
            }
            ViewBag.WeatherDataId = new SelectList(db.WeatherDatas, "WeatherDataId", "WeatherDataId", weatherInformation.WeatherDataId);
            return View(weatherInformation);
        }

        // POST: WeatherInformations/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "WeatherInformationId,WebAddress,WebData,RequestData,ResponseData,WeatherDataId")] WeatherInformation weatherInformation)
        {
            if (ModelState.IsValid)
            {
                db.Entry(weatherInformation).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.WeatherDataId = new SelectList(db.WeatherDatas, "WeatherDataId", "WeatherDataId", weatherInformation.WeatherDataId);
            return View(weatherInformation);
        }

        // GET: WeatherInformations/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WeatherInformation weatherInformation = db.WeatherInformations.Find(id);
            if (weatherInformation == null)
            {
                return HttpNotFound();
            }
            return View(weatherInformation);
        }

        // POST: WeatherInformations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            WeatherInformation weatherInformation = db.WeatherInformations.Find(id);
            db.WeatherInformations.Remove(weatherInformation);
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
