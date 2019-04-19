using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.Remoting.Messaging;
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
                new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Depo depo = db.Depo.Find(id);

            if (depo == null)
            {
                HttpNotFound();
            }

            return View(depo);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Ad")]Depo depo)
        {
            if (ModelState.IsValid)
            {
                db.Depo.Add(depo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(depo);
        }
    }
}