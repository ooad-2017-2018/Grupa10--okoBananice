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
    public class PotrosacsController : Controller
    {
        private PostaContext db = new PostaContext();

        // GET: Potrosacs
        public ActionResult Index()
        {
            return View(db.Potrosac.ToList());
        }

        // GET: Potrosacs/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Potrosac potrosac = db.Potrosac.Find(id);
            if (potrosac == null)
            {
                return HttpNotFound();
            }
            return View(potrosac);
        }

        // GET: Potrosacs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Potrosacs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,ime,prezime,brojTelefona,adresa,JMBG,email,password,datumRodjenja")] Potrosac potrosac)
        {
            if (ModelState.IsValid)
            {
                db.Potrosac.Add(potrosac);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(potrosac);
        }

        // GET: Potrosacs/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Potrosac potrosac = db.Potrosac.Find(id);
            if (potrosac == null)
            {
                return HttpNotFound();
            }
            return View(potrosac);
        }

        // POST: Potrosacs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,ime,prezime,brojTelefona,adresa,JMBG,email,password,datumRodjenja")] Potrosac potrosac)
        {
            if (ModelState.IsValid)
            {
                db.Entry(potrosac).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(potrosac);
        }

        // GET: Potrosacs/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Potrosac potrosac = db.Potrosac.Find(id);
            if (potrosac == null)
            {
                return HttpNotFound();
            }
            return View(potrosac);
        }

        // POST: Potrosacs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Potrosac potrosac = db.Potrosac.Find(id);
            db.Potrosac.Remove(potrosac);
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
