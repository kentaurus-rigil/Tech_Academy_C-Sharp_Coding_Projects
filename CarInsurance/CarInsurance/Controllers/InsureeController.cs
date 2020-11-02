﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CarInsurance.Models;

namespace CarInsurance.Controllers
{
    public class InsureeController : Controller
    {
        private InsuranceEntities db = new InsuranceEntities();

        // GET: Insuree
        public ActionResult Index()
        {
            return View(db.Insurees.ToList());
        }

        // GET: Insuree/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // GET: Insuree/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Insuree/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                insuree.Quote = 50;
                var today = DateTime.Now.Year;
                var age = today - insuree.DateOfBirth.Year;

                if(age <= 18)
                {
                    insuree.Quote += 100;
                }
                else if(age > 19 && age < 25 )
                {
                    insuree.Quote += 50;
                }
                else if(age > 25)
                {
                    insuree.Quote += 25;
                }
                if(insuree.CarYear < 2000)
                {
                    insuree.Quote += 25;
                }
                if(insuree.CarYear > 2015)
                {
                    insuree.Quote += 25;
                }
                if(insuree.CarMake == "Porsche")
                {
                    insuree.Quote += 25;
                }
                if(insuree.CarMake == "Porsche" && insuree.CarModel == "911 Carrera")
                {
                    insuree.Quote += 25;
                }
                var SpeedingTicketsFee = insuree.SpeedingTickets * 10;
                if(SpeedingTicketsFee > 0)
                {
                    insuree.Quote += SpeedingTicketsFee;
                }
                decimal twentyFive = 1.25M;
                if(insuree.DUI == true)
                {
                    insuree.Quote *= twentyFive;
                }
                decimal fifty = 1.5M;
                if(insuree.CoverageType == true)
                {
                    insuree.Quote *= fifty;
                }

                db.Insurees.Add(insuree);
                db.SaveChanges();
                return RedirectToAction("Details", new {insuree.Id});
            }

            return View(insuree);
        }

        // GET: Insuree/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                insuree.Quote = 50;
                var today = DateTime.Now.Year;
                var age = today - insuree.DateOfBirth.Year;

                if (age <= 18)
                {
                    insuree.Quote += 100;
                }
                else if (age > 19 && age < 25)
                {
                    insuree.Quote += 50;
                }
                else if (age > 25)
                {
                    insuree.Quote += 25;
                }
                if (insuree.CarYear < 2000)
                {
                    insuree.Quote += 25;
                }
                if (insuree.CarYear > 2015)
                {
                    insuree.Quote += 25;
                }
                if (insuree.CarMake == "Porsche")
                {
                    insuree.Quote += 25;
                }
                if (insuree.CarMake == "Porsche" && insuree.CarModel == "911 Carrera")
                {
                    insuree.Quote += 25;
                }
                var SpeedingTicketsFee = insuree.SpeedingTickets * 10;
                if (SpeedingTicketsFee > 0)
                {
                    insuree.Quote += SpeedingTicketsFee;
                }
                decimal twentyFive = 1.25M;
                if (insuree.DUI == true)
                {
                    insuree.Quote *= twentyFive;
                }
                decimal fifty = 1.5M;
                if (insuree.CoverageType == true)
                {
                    insuree.Quote *= fifty;
                }
                db.Entry(insuree).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Details", new { insuree.Id });
            }
            return View(insuree);
        }

        // GET: Insuree/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {

            Insuree insuree = db.Insurees.Find(id);
            db.Insurees.Remove(insuree);
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