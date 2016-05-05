using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using IrrigationAdvisor.Models;
using IrrigationAdvisor.Models.Irrigation;

using IrrigationAdvisor.DBContext;

namespace IrrigationAdvisor.Controllers.Irrigation
{
    public class DripsController : Controller
    {
        private IrrigationAdvisorContext db = new IrrigationAdvisorContext();

        // GET: Drips
        public ActionResult Index()
        {
            return View(db.Drips.ToList());
        }

        // GET: Drips/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Drip drip = db.Drips.Find(id);
            if (drip == null)
            {
                return HttpNotFound();
            }
            return View(drip);
        }

        // GET: Drips/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Drips/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IrrigationUnitId,Name,IrrigationType,IrrigationEfficiency,Surface,Width,Length")] Drip drip)
        {
            if (ModelState.IsValid)
            {
                db.Drips.Add(drip);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(drip);
        }

        // GET: Drips/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Drip drip = db.Drips.Find(id);
            if (drip == null)
            {
                return HttpNotFound();
            }
            return View(drip);
        }

        // POST: Drips/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IrrigationUnitId,Name,IrrigationType,IrrigationEfficiency,Surface,Width,Length")] Drip drip)
        {
            if (ModelState.IsValid)
            {
                db.Entry(drip).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(drip);
        }

        // GET: Drips/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Drip drip = db.Drips.Find(id);
            if (drip == null)
            {
                return HttpNotFound();
            }
            return View(drip);
        }

        // POST: Drips/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            Drip drip = db.Drips.Find(id);
            db.Drips.Remove(drip);
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
