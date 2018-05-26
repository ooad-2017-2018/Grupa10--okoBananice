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
    public class UposleniksController : Controller
    {
        private PostaContext db = new PostaContext();

        // GET: Uposleniks
        public ActionResult Index()
        {
            return View(db.Uposlenik.ToList());
        }

        // GET: Uposleniks/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Uposlenik uposlenik = db.Uposlenik.Find(id);
            if (uposlenik == null)
            {
                return HttpNotFound();
            }
            return View(uposlenik);
        }

        [HttpGet]
        public JsonResult GetAccount(string email, string password)
        {
            Uposlenik u = db.Uposlenik.OfType<Uposlenik>().SingleOrDefault(s => s.email == email && s.password == password);

            if (u == null)
                return Json(0, JsonRequestBehavior.AllowGet);

            return Json(u, JsonRequestBehavior.AllowGet);
        }

        // GET: Uposleniks/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Uposleniks/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,ime,prezime,email,password,adresa,datumRodjenja,tipPosla")] Uposlenik uposlenik)
        {
            if (ModelState.IsValid)
            {
                db.Uposlenik.Add(uposlenik);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(uposlenik);
        }

        // GET: Uposleniks/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Uposlenik uposlenik = db.Uposlenik.Find(id);
            if (uposlenik == null)
            {
                return HttpNotFound();
            }
            return View(uposlenik);
        }

        // POST: Uposleniks/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,ime,prezime,email,password,adresa,datumRodjenja,tipPosla")] Uposlenik uposlenik)
        {
            if (ModelState.IsValid)
            {
                db.Entry(uposlenik).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(uposlenik);
        }

        // GET: Uposleniks/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Uposlenik uposlenik = db.Uposlenik.Find(id);
            if (uposlenik == null)
            {
                return HttpNotFound();
            }
            return View(uposlenik);
        }

        // POST: Uposleniks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Uposlenik uposlenik = db.Uposlenik.Find(id);
            db.Uposlenik.Remove(uposlenik);
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
