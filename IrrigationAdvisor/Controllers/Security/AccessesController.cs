using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using IrrigationAdvisor.Models;
using IrrigationAdvisor.Models.Security;

using IrrigationAdvisor.DBContext;

namespace IrrigationAdvisor.Controllers.Security
{
    public class AccessesController : Controller
    {
        private IrrigationAdvisorContext db = new IrrigationAdvisorContext();

        // GET: Accesses
        public ActionResult Index()
        {
            return View(db.Accesses.ToList());
        }

        // GET: Accesses/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Access access = db.Accesses.Find(id);
            if (access == null)
            {
                return HttpNotFound();
            }
            return View(access);
        }

        // GET: Accesses/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Accesses/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "AccessId,Name")] Access access)
        {
            if (ModelState.IsValid)
            {
                db.Accesses.Add(access);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(access);
        }

        // GET: Accesses/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Access access = db.Accesses.Find(id);
            if (access == null)
            {
                return HttpNotFound();
            }
            return View(access);
        }

        // POST: Accesses/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "AccessId,Name")] Access access)
        {
            if (ModelState.IsValid)
            {
                db.Entry(access).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(access);
        }

        // GET: Accesses/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Access access = db.Accesses.Find(id);
            if (access == null)
            {
                return HttpNotFound();
            }
            return View(access);
        }

        // POST: Accesses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            Access access = db.Accesses.Find(id);
            db.Accesses.Remove(access);
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
