using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using HumanResourceList.Models;

namespace HumanResourceList.Controllers
{
    public class HumanReasourceListsController : Controller
    {
        private HumanReasourceDBContext db = new HumanReasourceDBContext();

        // GET: HumanReasourceLists
        public ActionResult Index()
        {
            return View(db.HumanResource.ToList());
        }

        // GET: HumanReasourceLists/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HumanReasourceList humanReasourceList = db.HumanResource.Find(id);
            if (humanReasourceList == null)
            {
                return HttpNotFound();
            }
            return View(humanReasourceList);
        }

        // GET: HumanReasourceLists/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HumanReasourceLists/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,FirstName,LastName,Email,DOB,DepartmentName,Status,EmpNo")] HumanReasourceList humanReasourceList)
        {
            if (ModelState.IsValid)
            {
                db.HumanResource.Add(humanReasourceList);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(humanReasourceList);
        }

        // GET: HumanReasourceLists/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HumanReasourceList humanReasourceList = db.HumanResource.Find(id);
            if (humanReasourceList == null)
            {
                return HttpNotFound();
            }
            return View(humanReasourceList);
        }

        // POST: HumanReasourceLists/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,FirstName,LastName,Email,DOB,DepartmentName,Status,EmpNo")] HumanReasourceList humanReasourceList)
        {
            if (ModelState.IsValid)
            {
                db.Entry(humanReasourceList).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(humanReasourceList);
        }

        // GET: HumanReasourceLists/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HumanReasourceList humanReasourceList = db.HumanResource.Find(id);
            if (humanReasourceList == null)
            {
                return HttpNotFound();
            }
            return View(humanReasourceList);
        }

        // POST: HumanReasourceLists/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            HumanReasourceList humanReasourceList = db.HumanResource.Find(id);
            db.HumanResource.Remove(humanReasourceList);
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
