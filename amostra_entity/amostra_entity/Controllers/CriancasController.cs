using System;
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
    public class CriancasController : Controller
    {
        private Context db = new Context();

        // GET: Criancas
        public ActionResult Index()
        {
            return View(db.Criancas.ToList());
        }

        // GET: Criancas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Crianca crianca = db.Criancas.Find(id);
            if (crianca == null)
            {
                return HttpNotFound();
            }
            return View(crianca);
        }

        // GET: Criancas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Criancas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,nome")] Crianca crianca)
        {
            if (ModelState.IsValid)
            {
                db.Criancas.Add(crianca);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(crianca);
        }

        // GET: Criancas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Crianca crianca = db.Criancas.Find(id);
            if (crianca == null)
            {
                return HttpNotFound();
            }
            return View(crianca);
        }

        // POST: Criancas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,nome")] Crianca crianca)
        {
            if (ModelState.IsValid)
            {
                db.Entry(crianca).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(crianca);
        }

        // GET: Criancas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Crianca crianca = db.Criancas.Find(id);
            if (crianca == null)
            {
                return HttpNotFound();
            }
            return View(crianca);
        }

        // POST: Criancas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Crianca crianca = db.Criancas.Find(id);
            db.Criancas.Remove(crianca);
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
