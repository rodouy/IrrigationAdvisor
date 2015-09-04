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
    public class SprinklersController : Controller
    {
        private IrrigationAdvisorContext db = new IrrigationAdvisorContext();

        // GET: Sprinklers
        public ActionResult Index()
        {
            return View(db.Sprinklers.ToList());
        }

        // GET: Sprinklers/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sprinkler sprinkler = db.Sprinklers.Find(id);
            if (sprinkler == null)
            {
                return HttpNotFound();
            }
            return View(sprinkler);
        }

        // GET: Sprinklers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Sprinklers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IrrigationUnitId,Name,IrrigationType,IrrigationEfficiency,Surface,Width,Length")] Sprinkler sprinkler)
        {
            if (ModelState.IsValid)
            {
                db.Sprinklers.Add(sprinkler);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(sprinkler);
        }

        // GET: Sprinklers/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sprinkler sprinkler = db.Sprinklers.Find(id);
            if (sprinkler == null)
            {
                return HttpNotFound();
            }
            return View(sprinkler);
        }

        // POST: Sprinklers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IrrigationUnitId,Name,IrrigationType,IrrigationEfficiency,Surface,Width,Length")] Sprinkler sprinkler)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sprinkler).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(sprinkler);
        }

        // GET: Sprinklers/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sprinkler sprinkler = db.Sprinklers.Find(id);
            if (sprinkler == null)
            {
                return HttpNotFound();
            }
            return View(sprinkler);
        }

        // POST: Sprinklers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            Sprinkler sprinkler = db.Sprinklers.Find(id);
            db.Sprinklers.Remove(sprinkler);
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
