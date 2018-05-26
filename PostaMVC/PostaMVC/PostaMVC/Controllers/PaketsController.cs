using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Posta.Model;
using PostaMVC.Models;

namespace PostaMVC.Controllers
{
    public class PaketsController : Controller
    {
        private PostaContext db = new PostaContext();

        // GET: Pakets
        public ActionResult Index()
        {
            return View(db.Paket.ToList());
        }

        // GET: Pakets/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Paket paket = db.Paket.Find(id);
            if (paket == null)
            {
                return HttpNotFound();
            }
            return View(paket);
        }

        // GET: Pakets/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Pakets/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,grad,drzava,cijena,tezina")] Paket paket)
        {
            if (ModelState.IsValid)
            {
                db.Paket.Add(paket);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(paket);
        }

        // GET: Pakets/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Paket paket = db.Paket.Find(id);
            if (paket == null)
            {
                return HttpNotFound();
            }
            return View(paket);
        }

        // POST: Pakets/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,grad,drzava,cijena,tezina")] Paket paket)
        {
            if (ModelState.IsValid)
            {
                db.Entry(paket).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(paket);
        }

        // GET: Pakets/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Paket paket = db.Paket.Find(id);
            if (paket == null)
            {
                return HttpNotFound();
            }
            return View(paket);
        }

        // POST: Pakets/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Paket paket = db.Paket.Find(id);
            db.Paket.Remove(paket);
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
