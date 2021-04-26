using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BARDSports.Models;
using Microsoft.AspNet.Identity;

namespace BARDSports.Controllers
{
    //Comments is a base class and public property
    public class CommentsController : Controller // Note: "Inheritance". This updated line is from the originally generated "CommentsController".
    {
        //Declaring an object of type ApplicationDbContext.
        //private data member db
        private ApplicationDbContext db = new ApplicationDbContext();


        // GET: Comments
        public ActionResult Index()
        {
            var commentsModels = db.CommentsModels.Include(p => p.Player);
            return View(commentsModels.ToList());
        }

        // GET: Comments/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CommentsModel commentsModel = db.CommentsModels.Find(id);
            if (commentsModel == null)
            {
                return HttpNotFound();
            }
            return View(commentsModel);
        }

        // GET: Comments/Create
        public ActionResult Create()
        {
            ViewBag.PlayerId = new SelectList(db.PlayerModels, "PlayerId", "Firstname");
            

            return View();
        }

        // POST: Comments/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CommentsId,PlayerId,Id,Rating,Date")] CommentsModel commentsModel)
        {
            var UserId = User.Identity.GetUserId();
            commentsModel.Id = UserId;
            if (ModelState.IsValid)
            {
                db.CommentsModels.Add(commentsModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.PlayerId = new SelectList(db.PlayerModels, "PlayerId", "Firstname", commentsModel.PlayerId);
            return View(commentsModel);
        }

        // GET: Comments/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CommentsModel commentsModel = db.CommentsModels.Find(id);
            if (commentsModel == null)
            {
                return HttpNotFound();
            }
            ViewBag.PlayerId = new SelectList(db.PlayerModels, "PlayerId", "Firstname", commentsModel.PlayerId);
            return View(commentsModel);
        }

        // POST: Comments/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CommentsId,PlayerId,Id,Rating,Date")] CommentsModel commentsModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(commentsModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.PlayerId = new SelectList(db.PlayerModels, "PlayerId", "Firstname", commentsModel.PlayerId);
            return View(commentsModel);
        }

        // GET: Comments/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CommentsModel commentsModel = db.CommentsModels.Find(id);
            if (commentsModel == null)
            {
                return HttpNotFound();
            }
            return View(commentsModel);
        }

        // POST: Comments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CommentsModel commentsModel = db.CommentsModels.Find(id);
            db.CommentsModels.Remove(commentsModel);
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
