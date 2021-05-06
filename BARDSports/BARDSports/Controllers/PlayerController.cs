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
    //Player controller is a base class and public property
    public class PlayerController : Controller // Note: "Inheritance". This updated line is from the originally generated "PlayerController".
    {
        //Declaring an object of type ApplicationDbContext.
        //private data member db
        private ApplicationDbContext db = new ApplicationDbContext();

        //private member variables
        private string mFirstname;
        private string mLastname;
        private DateTime mDateOfBirth;
        private string mPosition;
        private string mGoals;
        private string mAssists;
        private string mYellowCards;
        private string mRedCards;

        //Encapsulation (get, set methods)
        //firstname public property
        public string Firstname
        {
            //return the private data
            get
            {

                //this line of code sends data out of the property                
                return mFirstname;
            }
            //set the private data
            set
            {                
                // this line of code allows into the property
                mFirstname = value;
            }
        }
        //lastname public property
        public string Lastname {
            get
            {
                //return the private data
                return mLastname;
            }
            set
            {
                //set the private data
                mLastname = value;

            }
        }
        //dat of birth public property
        public DateTime DateOfBirth {
            get
            {
                //return the private data
                return mDateOfBirth;
            }
            set
            {
                //set the private data
                mDateOfBirth = value;
            }
        }
        //position public property
        public string Position {
            get
            {
                //return the private data
                return mPosition;
            }
            set
            {
                //set the private data
                mPosition = value;

            }
        }
        //goals public property
        public string Goals {
            get
            {
                //return the private data
                return mGoals;
            }
            set
            {
                //set the private data
                mGoals = value;

            }
        }
        //assists public property
        public string Assists {
            get
            {
                //return the private data
                return mAssists;
            }
            set
            {
                //set the private data
                mAssists = value;

            }
        }
        //yellow cards public property
        public string YellowCards {
            get
            {
                //return the private data
                return mYellowCards;
            }
            set
            {
                //set the private data
                mYellowCards = value;

            }
        }
        //red cards public property
        public string RedCards {
            get
            {
                //return the private data
                return mRedCards;
            }
            set
            {
                //set the private data
                mRedCards = value;

            }
        }

        // GET: Player
        public ActionResult Index(int? id)
        {
            if (id == null)
            {
                var playerModels = db.PlayerModels.Include(p => p.Football);
                return View(playerModels.ToList());
            }
            else
            {
                
                return View(db.PlayerModels.Where(PlayerModel => PlayerModel.FootballClubId == id).ToList());
            }
           
        }

        // GET: Player/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PlayerModel playerModel = db.PlayerModels.Find(id);
            if (playerModel == null)
            {
                return HttpNotFound();
            }
            return View(playerModel);
        }

        // GET: Player/Create
        public ActionResult Create()
        {
            ViewBag.FootballClubId = new SelectList(db.FootballClubModels, "FootballClubId", "FootballClubName");
            return View();
        }

        // POST: Player/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "PlayerId,FootballClubId,Firstname,Lastname,DateOfBirth,Position,Goals,Assists,YellowCards,RedCards")] PlayerModel playerModel)
        {
            if (ModelState.IsValid)
            {
                db.PlayerModels.Add(playerModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.FootballClubId = new SelectList(db.FootballClubModels, "FootballClubId", "FootballClubName", playerModel.FootballClubId);
            return View(playerModel);
        }

        // GET: Player/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PlayerModel playerModel = db.PlayerModels.Find(id);
            if (playerModel == null)
            {
                return HttpNotFound();
            }
            ViewBag.FootballClubId = new SelectList(db.FootballClubModels, "FootballClubId", "FootballClubName", playerModel.FootballClubId);
            return View(playerModel);
        }

       

        // POST: Player/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "PlayerId,FootballClubId,Firstname,Lastname,DateOfBirth,Position,Goals,Assists,YellowCards,RedCards")] PlayerModel playerModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(playerModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.FootballClubId = new SelectList(db.FootballClubModels, "FootballClubId", "FootballClubName", playerModel.FootballClubId);
            return View(playerModel);
        }

        // GET: Player/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PlayerModel playerModel = db.PlayerModels.Find(id);
            if (playerModel == null)
            {
                return HttpNotFound();
            }
            return View(playerModel);
        }

        // POST: Player/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PlayerModel playerModel = db.PlayerModels.Find(id);
            db.PlayerModels.Remove(playerModel);
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
