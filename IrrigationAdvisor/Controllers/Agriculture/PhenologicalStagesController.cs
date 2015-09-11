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
    public class PhenologicalStagesController : Controller
    {
        private IrrigationAdvisorContext db = new IrrigationAdvisorContext();

        // GET: PhenologicalStages
        public ActionResult Index()
        {
            return View(db.PhenologicalStages.ToList());
        }

        // GET: PhenologicalStages/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PhenologicalStage phenologicalStage = db.PhenologicalStages.Find(id);
            if (phenologicalStage == null)
            {
                return HttpNotFound();
            }
            return View(phenologicalStage);
        }

        // GET: PhenologicalStages/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PhenologicalStages/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "PhenologicalStageId,MinDegree,MaxDegree,RootDepth,HydricBalanceDepth")] PhenologicalStage phenologicalStage)
        {
            if (ModelState.IsValid)
            {
                db.PhenologicalStages.Add(phenologicalStage);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(phenologicalStage);
        }

        // GET: PhenologicalStages/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PhenologicalStage phenologicalStage = db.PhenologicalStages.Find(id);
            if (phenologicalStage == null)
            {
                return HttpNotFound();
            }
            return View(phenologicalStage);
        }

        // POST: PhenologicalStages/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "PhenologicalStageId,MinDegree,MaxDegree,RootDepth,HydricBalanceDepth")] PhenologicalStage phenologicalStage)
        {
            if (ModelState.IsValid)
            {
                db.Entry(phenologicalStage).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(phenologicalStage);
        }

        // GET: PhenologicalStages/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PhenologicalStage phenologicalStage = db.PhenologicalStages.Find(id);
            if (phenologicalStage == null)
            {
                return HttpNotFound();
            }
            return View(phenologicalStage);
        }

        // POST: PhenologicalStages/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            PhenologicalStage phenologicalStage = db.PhenologicalStages.Find(id);
            db.PhenologicalStages.Remove(phenologicalStage);
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
