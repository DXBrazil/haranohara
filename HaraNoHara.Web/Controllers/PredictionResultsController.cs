using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using HaraNoHara.Web.Models;

namespace HaraNoHara.Web.Controllers
{
    public class PredictionResultsController : Controller
    {
        private HaraNoHaraWebContext db = new HaraNoHaraWebContext();

        // GET: PredictionResults
        public ActionResult Index()
        {
            return View(db.PredictionResults.ToList());
        }

        // GET: PredictionResults/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PredictionResults predictionResults = db.PredictionResults.Find(id);
            if (predictionResults == null)
            {
                return HttpNotFound();
            }
            return View(predictionResults);
        }

        // GET: PredictionResults/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PredictionResults/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,tag,prediction")] PredictionResults predictionResults)
        {
            if (ModelState.IsValid)
            {
                db.PredictionResults.Add(predictionResults);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(predictionResults);
        }

        // GET: PredictionResults/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PredictionResults predictionResults = db.PredictionResults.Find(id);
            if (predictionResults == null)
            {
                return HttpNotFound();
            }
            return View(predictionResults);
        }

        // POST: PredictionResults/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,tag,prediction")] PredictionResults predictionResults)
        {
            if (ModelState.IsValid)
            {
                db.Entry(predictionResults).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(predictionResults);
        }

        // GET: PredictionResults/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PredictionResults predictionResults = db.PredictionResults.Find(id);
            if (predictionResults == null)
            {
                return HttpNotFound();
            }
            return View(predictionResults);
        }

        // POST: PredictionResults/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PredictionResults predictionResults = db.PredictionResults.Find(id);
            db.PredictionResults.Remove(predictionResults);
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
