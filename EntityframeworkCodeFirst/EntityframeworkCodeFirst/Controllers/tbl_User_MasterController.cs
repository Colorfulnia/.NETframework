using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using EntityframeworkCodeFirst;

namespace EntityframeworkCodeFirst.Controllers
{
    public class tbl_User_MasterController : Controller
    {
        private Model1 db = new Model1();

        // GET: tbl_User_Master
        public ActionResult Index()
        {
            return View(db.tbl_User_Master.ToList());
        }

        // GET: tbl_User_Master/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_User_Master tbl_User_Master = db.tbl_User_Master.Find(id);
            if (tbl_User_Master == null)
            {
                return HttpNotFound();
            }
            return View(tbl_User_Master);
        }

        // GET: tbl_User_Master/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: tbl_User_Master/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "User_Id,Username,Password,Full_Name,Last_Login_Datetime,Active_Status")] tbl_User_Master tbl_User_Master)
        {
            if (ModelState.IsValid)
            {
                db.tbl_User_Master.Add(tbl_User_Master);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tbl_User_Master);
        }

        // GET: tbl_User_Master/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_User_Master tbl_User_Master = db.tbl_User_Master.Find(id);
            if (tbl_User_Master == null)
            {
                return HttpNotFound();
            }
            return View(tbl_User_Master);
        }

        // POST: tbl_User_Master/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "User_Id,Username,Password,Full_Name,Last_Login_Datetime,Active_Status")] tbl_User_Master tbl_User_Master)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tbl_User_Master).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tbl_User_Master);
        }

        // GET: tbl_User_Master/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_User_Master tbl_User_Master = db.tbl_User_Master.Find(id);
            if (tbl_User_Master == null)
            {
                return HttpNotFound();
            }
            return View(tbl_User_Master);
        }

        // POST: tbl_User_Master/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tbl_User_Master tbl_User_Master = db.tbl_User_Master.Find(id);
            db.tbl_User_Master.Remove(tbl_User_Master);
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
