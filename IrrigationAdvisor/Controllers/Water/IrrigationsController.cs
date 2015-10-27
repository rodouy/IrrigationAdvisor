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
    public class IrrigationsController : Controller
    {
        private IrrigationAdvisorContext db = new IrrigationAdvisorContext();

        // GET: Irrigations
        public ActionResult Index()
        {
            return View(db.Irrigations.ToList());
        }

        // GET: Irrigations/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Models.Water.Irrigation irrigation = db.Irrigations.Find(id);
            if (irrigation == null)
            {
                return HttpNotFound();
            }
            return View(irrigation);
        }

        // GET: Irrigations/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Irrigations/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "WaterInputId,Type,Input,Date,ExtraInput,ExtraDate")] Models.Water.Irrigation irrigation)
        {
            if (ModelState.IsValid)
            {
                db.Irrigations.Add(irrigation);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(irrigation);
        }

        // GET: Irrigations/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Models.Water.Irrigation irrigation = db.Irrigations.Find(id);
            if (irrigation == null)
            {
                return HttpNotFound();
            }
            return View(irrigation);
        }

        // POST: Irrigations/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "WaterInputId,Type,Input,Date,ExtraInput,ExtraDate")] Models.Water.Irrigation irrigation)
        {
            if (ModelState.IsValid)
            {
                db.Entry(irrigation).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(irrigation);
        }

        // GET: Irrigations/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Models.Water.Irrigation irrigation = db.Irrigations.Find(id);
            if (irrigation == null)
            {
                return HttpNotFound();
            }
            return View(irrigation);
        }

        // POST: Irrigations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            Models.Water.Irrigation irrigation = db.Irrigations.Find(id);
            db.Irrigations.Remove(irrigation);
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
