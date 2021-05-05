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
    public class AdvertController : Controller
    {
        //Declaring an object of type ApplicationDbContext.
        private ApplicationDbContext db = new ApplicationDbContext();
       //get set method
        public string Description { get; set; }

        //public string valid(string Description)//, DateTime DOB)
        //{
        //    string errorMsg = "rgtsryr";

        //    if (Description.Length < 2)
        //    {
        //        errorMsg = "";
        //    }
        //    if (Description.Length > 20)
        //    {
        //        errorMsg = "shddt";
        //    }

        //    if (DOB > DateTime.Now.AddYears(-16))
        //    {
        //        errorMsg = "too young";
        //    }
        //    if (DOB < DateTime.Now.AddYears(-110))
        //    {
        //        errorMsg = "too old";
        //    }

        //    return errorMsg;

        //}

        // GET: Advert
        public ActionResult Index()
        {
            var advertModels = db.AdvertModels.Include(a => a.League);
            return View(advertModels.ToList());
        }

        // GET: Advert/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AdvertModel advertModel = db.AdvertModels.Find(id);
            if (advertModel == null)
            {
                return HttpNotFound();
            }
            return View(advertModel);
        }

        // GET: Advert/Create
        public ActionResult Create()
        {
            ViewBag.LeagueId = new SelectList(db.LeagueModels, "LeagueId", "LeagueName");
            return View();
        }

        // POST: Advert/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "AdvertId,LeagueId,Description,Image")] AdvertModel advertModel)
        {
            if (ModelState.IsValid)
            {
                db.AdvertModels.Add(advertModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.LeagueId = new SelectList(db.LeagueModels, "LeagueId", "LeagueName", advertModel.LeagueId);
            return View(advertModel);
        }

        // GET: Advert/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AdvertModel advertModel = db.AdvertModels.Find(id);
            if (advertModel == null)
            {
                return HttpNotFound();
            }
            ViewBag.LeagueId = new SelectList(db.LeagueModels, "LeagueId", "LeagueName", advertModel.LeagueId);
            return View(advertModel);
        }

        // POST: Advert/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "AdvertId,LeagueId,Description,Image")] AdvertModel advertModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(advertModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.LeagueId = new SelectList(db.LeagueModels, "LeagueId", "LeagueName", advertModel.LeagueId);
            return View(advertModel);
        }

        // GET: Advert/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AdvertModel advertModel = db.AdvertModels.Find(id);
            if (advertModel == null)
            {
                return HttpNotFound();
            }
            return View(advertModel);
        }

        // POST: Advert/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            AdvertModel advertModel = db.AdvertModels.Find(id);
            db.AdvertModels.Remove(advertModel);
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
