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
    public class SiteMapsController : Controller
    {
        private IrrigationAdvisorContext db = new IrrigationAdvisorContext();

        // GET: SiteMaps
        public ActionResult Index()
        {
            return View(db.SiteMaps.ToList());
        }

        // GET: SiteMaps/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Models.Security.SiteMap siteMap = db.SiteMaps.Find(id);
            if (siteMap == null)
            {
                return HttpNotFound();
            }
            return View(siteMap);
        }

        // GET: SiteMaps/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SiteMaps/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "SiteMapId,Name")] Models.Security.SiteMap siteMap)
        {
            if (ModelState.IsValid)
            {
                db.SiteMaps.Add(siteMap);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(siteMap);
        }

        // GET: SiteMaps/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Models.Security.SiteMap siteMap = db.SiteMaps.Find(id);
            if (siteMap == null)
            {
                return HttpNotFound();
            }
            return View(siteMap);
        }

        // POST: SiteMaps/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "SiteMapId,Name")] Models.Security.SiteMap siteMap)
        {
            if (ModelState.IsValid)
            {
                db.Entry(siteMap).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(siteMap);
        }

        // GET: SiteMaps/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Models.Security.SiteMap siteMap = db.SiteMaps.Find(id);
            if (siteMap == null)
            {
                return HttpNotFound();
            }
            return View(siteMap);
        }

        // POST: SiteMaps/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            Models.Security.SiteMap siteMap = db.SiteMaps.Find(id);
            db.SiteMaps.Remove(siteMap);
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
