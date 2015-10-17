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
    public class RainsController : Controller
    {
        private IrrigationAdvisorContext db = new IrrigationAdvisorContext();

        // GET: Rains
        public ActionResult Index()
        {
            return View(db.Rains.ToList());
        }

        // GET: Rains/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Rain rain = db.Rains.Find(id);
            if (rain == null)
            {
                return HttpNotFound();
            }
            return View(rain);
        }

        // GET: Rains/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Rains/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "WaterInputId,Type,Input,Date,ExtraInput,ExtraDate")] Rain rain)
        {
            if (ModelState.IsValid)
            {
                db.Rains.Add(rain);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(rain);
        }

        // GET: Rains/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Rain rain = db.Rains.Find(id);
            if (rain == null)
            {
                return HttpNotFound();
            }
            return View(rain);
        }

        // POST: Rains/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "WaterInputId,Type,Input,Date,ExtraInput,ExtraDate")] Rain rain)
        {
            if (ModelState.IsValid)
            {
                db.Entry(rain).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(rain);
        }

        // GET: Rains/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Rain rain = db.Rains.Find(id);
            if (rain == null)
            {
                return HttpNotFound();
            }
            return View(rain);
        }

        // POST: Rains/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            Rain rain = db.Rains.Find(id);
            db.Rains.Remove(rain);
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
