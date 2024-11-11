using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Thi63TTQL1_63132131.Models;

namespace Thi63TTQL1_63132131.Controllers
{
    public class GiangVien_63132131Controller : Controller
    {
        private Thi63TTQL1_63132131Entities db = new Thi63TTQL1_63132131Entities();

        // GET: GiangVien_63132131
        public ActionResult GioiThieu()
        {
            return View();
        }
        public ActionResult DanhSach()
        {
            return View();
        }
        public ActionResult Index()
        {
            var giangViens = db.GiangViens.Include(g => g.BoMon);
            return View(giangViens.ToList());
        }

        // GET: GiangVien_63132131/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GiangVien giangVien = db.GiangViens.Find(id);
            if (giangVien == null)
            {
                return HttpNotFound();
            }
            return View(giangVien);
        }

        // GET: GiangVien_63132131/Create
        public ActionResult Create()
        {
            ViewBag.MaBM = new SelectList(db.BoMons, "MaBM", "TenBM");
            return View();
        }

        // POST: GiangVien_63132131/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaGV,HoGV,TenGV,NgaySinh,GioiTinh,Email,AnhGV,MaBM")] GiangVien giangVien)
        {
            if (ModelState.IsValid)
            {
                db.GiangViens.Add(giangVien);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.MaBM = new SelectList(db.BoMons, "MaBM", "TenBM", giangVien.MaBM);
            return View(giangVien);
        }

        // GET: GiangVien_63132131/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GiangVien giangVien = db.GiangViens.Find(id);
            if (giangVien == null)
            {
                return HttpNotFound();
            }
            ViewBag.MaBM = new SelectList(db.BoMons, "MaBM", "TenBM", giangVien.MaBM);
            return View(giangVien);
        }

        // POST: GiangVien_63132131/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaGV,HoGV,TenGV,NgaySinh,GioiTinh,Email,AnhGV,MaBM")] GiangVien giangVien)
        {
            if (ModelState.IsValid)
            {
                db.Entry(giangVien).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MaBM = new SelectList(db.BoMons, "MaBM", "TenBM", giangVien.MaBM);
            return View(giangVien);
        }

        // GET: GiangVien_63132131/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GiangVien giangVien = db.GiangViens.Find(id);
            if (giangVien == null)
            {
                return HttpNotFound();
            }
            return View(giangVien);
        }

        // POST: GiangVien_63132131/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            GiangVien giangVien = db.GiangViens.Find(id);
            db.GiangViens.Remove(giangVien);
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
