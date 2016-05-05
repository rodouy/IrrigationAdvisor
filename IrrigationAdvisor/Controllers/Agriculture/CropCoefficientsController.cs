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
    public class CropCoefficientsController : Controller
    {
        private IrrigationAdvisorContext db = new IrrigationAdvisorContext();

        // GET: CropCoefficients
        public ActionResult Index()
        {
            return View(db.CropCoefficients.ToList());
        }

        // GET: CropCoefficients/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CropCoefficient cropCoefficient = db.CropCoefficients.Find(id);
            if (cropCoefficient == null)
            {
                return HttpNotFound();
            }
            return View(cropCoefficient);
        }

        // GET: CropCoefficients/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CropCoefficients/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CropCoefficientId")] CropCoefficient cropCoefficient)
        {
            if (ModelState.IsValid)
            {
                db.CropCoefficients.Add(cropCoefficient);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cropCoefficient);
        }

        // GET: CropCoefficients/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CropCoefficient cropCoefficient = db.CropCoefficients.Find(id);
            if (cropCoefficient == null)
            {
                return HttpNotFound();
            }
            return View(cropCoefficient);
        }

        // POST: CropCoefficients/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CropCoefficientId")] CropCoefficient cropCoefficient)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cropCoefficient).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cropCoefficient);
        }

        // GET: CropCoefficients/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CropCoefficient cropCoefficient = db.CropCoefficients.Find(id);
            if (cropCoefficient == null)
            {
                return HttpNotFound();
            }
            return View(cropCoefficient);
        }

        // POST: CropCoefficients/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            CropCoefficient cropCoefficient = db.CropCoefficients.Find(id);
            db.CropCoefficients.Remove(cropCoefficient);
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
