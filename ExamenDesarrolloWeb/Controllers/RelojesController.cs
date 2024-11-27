using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ExamenBack.Model;

namespace ExamenDesarrolloWeb.Controllers
{
    public class RelojesController : Controller
    {
        private TiendaRJEntities db = new TiendaRJEntities();

        // GET: Relojes
        public ActionResult Index()
        {
            return View(db.Relojes.ToList());
        }

        // GET: Relojes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Relojes relojes = db.Relojes.Find(id);
            if (relojes == null)
            {
                return HttpNotFound();
            }
            return View(relojes);
        }

        // GET: Relojes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Relojes/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id_reloj,nombre,descripcion,precio,stock,imagen_url")] Relojes relojes)
        {
            if (ModelState.IsValid)
            {
                db.Relojes.Add(relojes);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(relojes);
        }

        // GET: Relojes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Relojes relojes = db.Relojes.Find(id);
            if (relojes == null)
            {
                return HttpNotFound();
            }
            return View(relojes);
        }

        // POST: Relojes/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id_reloj,nombre,descripcion,precio,stock,imagen_url")] Relojes relojes)
        {
            if (ModelState.IsValid)
            {
                db.Entry(relojes).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(relojes);
        }

        // GET: Relojes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Relojes relojes = db.Relojes.Find(id);
            if (relojes == null)
            {
                return HttpNotFound();
            }
            return View(relojes);
        }

        // POST: Relojes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Relojes relojes = db.Relojes.Find(id);
            db.Relojes.Remove(relojes);
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
