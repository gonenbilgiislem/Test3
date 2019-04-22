using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using Test3.Models;

namespace Test3.Controllers
{
    public class HomeController : Controller
    {
        private Model1 db = new Model1();

        public ActionResult Index()
        {
            return View(db.Depo.ToList());
        }

        public ActionResult Detail(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Depo depo = db.Depo.Find(id);

            if (depo == null)
            {
                return HttpNotFound();
            }

            return View(depo);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Ad,Soyad")]Depo depo)
        {
            if (ModelState.IsValid)
            {
                db.Depo.Add(depo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(depo);
        }

        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Depo depo = db.Depo.Find(id);
            if (depo == null)
            {
                return HttpNotFound();
            }
            return View(depo);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Ad,Soyad")]Depo depo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(depo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(depo);
        }

        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Depo depo = db.Depo.Find(id);
            if (depo == null)
            {
                return HttpNotFound();
            }

            return View(depo);
        }
        [HttpPost,ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
                Depo depo = db.Depo.Find(id);
              //  db.Depo.Remove(depo);
              db.Entry(depo).State = EntityState.Deleted; 
              db.SaveChanges();
              return View();
        }
    }
}