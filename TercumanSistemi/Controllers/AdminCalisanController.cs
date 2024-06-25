using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TercumanSistemi.Models.EntityFramework;

namespace TercumanSistemi.Controllers
{
    public class AdminCalisanController : Controller
    {
        tercuman_dbEntities db = new tercuman_dbEntities();
        // GET: AdminCalisan
        public ActionResult Index()
        {
            var calsanlar = db.Tbl_Calisan.ToList();
            return View(calsanlar);
        }
        [HttpGet]
        public ActionResult YeniCalisan()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniCalisan(Tbl_Calisan p)
        {
            if (!ModelState.IsValid)
            {
                return View("YeniCalisan");
            }
            p.Durum = true;
            db.Tbl_Calisan.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}