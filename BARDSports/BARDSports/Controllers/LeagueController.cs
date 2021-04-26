using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BARDSports.Models;

namespace BARDSports.Controllers
{
    //League controller is a base class and public property
    public class LeagueController : Controller // Note: "Inheritance". This updated line is from the originally generated "LeagueController".
    {
        //Declaring an object of type ApplicationDbContext.
        //private data member db
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: League
        public ActionResult Index()
        {
            return View(db.LeagueModels.ToList());
        }

        // GET: League/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LeagueModel leagueModel = db.LeagueModels.Find(id);
            if (leagueModel == null)
            {
                return HttpNotFound();
            }
            return View(leagueModel);
        }

        // GET: League/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: League/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "LeagueId,LeagueName,Description,Seasons")] LeagueModel leagueModel)
        {
            if (ModelState.IsValid)
            {
                db.LeagueModels.Add(leagueModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(leagueModel);
        }

        // GET: League/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LeagueModel leagueModel = db.LeagueModels.Find(id);
            if (leagueModel == null)
            {
                return HttpNotFound();
            }
            return View(leagueModel);
        }

        // POST: League/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "LeagueId,LeagueName,Description,Seasons")] LeagueModel leagueModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(leagueModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(leagueModel);
        }

        // GET: League/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LeagueModel leagueModel = db.LeagueModels.Find(id);
            if (leagueModel == null)
            {
                return HttpNotFound();
            }
            return View(leagueModel);
        }

        // POST: League/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            LeagueModel leagueModel = db.LeagueModels.Find(id);
            db.LeagueModels.Remove(leagueModel);
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
