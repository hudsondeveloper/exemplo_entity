﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using amostra_entity.Models;

namespace amostra_entity.Controllers
{
    public class BrinquedosController : Controller
    {
        private Context db = new Context();

        // GET: Brinquedos
        public ActionResult Index()
        {
            return View(db.Brinquedoes.ToList());
        }

        // GET: Brinquedos/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Brinquedo brinquedo = db.Brinquedoes.Find(id);
            if (brinquedo == null)
            {
                return HttpNotFound();
            }
            return View(brinquedo);
        }

        // GET: Brinquedos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Brinquedos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,nome,lojaId,criancaId")] Brinquedo brinquedo)
        {
            if (ModelState.IsValid)
            {
                db.Brinquedoes.Add(brinquedo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(brinquedo);
        }

        // GET: Brinquedos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Brinquedo brinquedo = db.Brinquedoes.Find(id);
            if (brinquedo == null)
            {
                return HttpNotFound();
            }
            return View(brinquedo);
        }

        // POST: Brinquedos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,nome,lojaId,criancaId")] Brinquedo brinquedo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(brinquedo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(brinquedo);
        }

        // GET: Brinquedos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Brinquedo brinquedo = db.Brinquedoes.Find(id);
            if (brinquedo == null)
            {
                return HttpNotFound();
            }
            return View(brinquedo);
        }

        // POST: Brinquedos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Brinquedo brinquedo = db.Brinquedoes.Find(id);
            db.Brinquedoes.Remove(brinquedo);
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
