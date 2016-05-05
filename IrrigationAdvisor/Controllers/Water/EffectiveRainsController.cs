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
    public class EffectiveRainsController : Controller
    {
        private IrrigationAdvisorContext db = new IrrigationAdvisorContext();

        // GET: EffectiveRains
        public ActionResult Index()
        {
            return View(db.EffectiveRains.ToList());
        }

        // GET: EffectiveRains/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EffectiveRain effectiveRain = db.EffectiveRains.Find(id);
            if (effectiveRain == null)
            {
                return HttpNotFound();
            }
            return View(effectiveRain);
        }

        // GET: EffectiveRains/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EffectiveRains/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "EffectiveRainId,Month,MinRain,MaxRain,Percentage")] EffectiveRain effectiveRain)
        {
            if (ModelState.IsValid)
            {
                db.EffectiveRains.Add(effectiveRain);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(effectiveRain);
        }

        // GET: EffectiveRains/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EffectiveRain effectiveRain = db.EffectiveRains.Find(id);
            if (effectiveRain == null)
            {
                return HttpNotFound();
            }
            return View(effectiveRain);
        }

        // POST: EffectiveRains/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "EffectiveRainId,Month,MinRain,MaxRain,Percentage")] EffectiveRain effectiveRain)
        {
            if (ModelState.IsValid)
            {
                db.Entry(effectiveRain).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(effectiveRain);
        }

        // GET: EffectiveRains/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EffectiveRain effectiveRain = db.EffectiveRains.Find(id);
            if (effectiveRain == null)
            {
                return HttpNotFound();
            }
            return View(effectiveRain);
        }

        // POST: EffectiveRains/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            EffectiveRain effectiveRain = db.EffectiveRains.Find(id);
            db.EffectiveRains.Remove(effectiveRain);
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
