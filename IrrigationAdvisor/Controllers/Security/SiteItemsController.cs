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
    public class SiteItemsController : Controller
    {
        private IrrigationAdvisorContext db = new IrrigationAdvisorContext();

        // GET: SiteItems
        public ActionResult Index()
        {
            return View(db.SiteItems.ToList());
        }

        // GET: SiteItems/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SiteItem siteItem = db.SiteItems.Find(id);
            if (siteItem == null)
            {
                return HttpNotFound();
            }
            return View(siteItem);
        }

        // GET: SiteItems/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SiteItems/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "SiteItemId,Name")] SiteItem siteItem)
        {
            if (ModelState.IsValid)
            {
                db.SiteItems.Add(siteItem);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(siteItem);
        }

        // GET: SiteItems/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SiteItem siteItem = db.SiteItems.Find(id);
            if (siteItem == null)
            {
                return HttpNotFound();
            }
            return View(siteItem);
        }

        // POST: SiteItems/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "SiteItemId,Name")] SiteItem siteItem)
        {
            if (ModelState.IsValid)
            {
                db.Entry(siteItem).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(siteItem);
        }

        // GET: SiteItems/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SiteItem siteItem = db.SiteItems.Find(id);
            if (siteItem == null)
            {
                return HttpNotFound();
            }
            return View(siteItem);
        }

        // POST: SiteItems/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            SiteItem siteItem = db.SiteItems.Find(id);
            db.SiteItems.Remove(siteItem);
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
