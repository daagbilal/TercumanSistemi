using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TercumanSistemi.Models.EntityFramework;

namespace TercumanSistemi.Controllers
{
    public class CalisanController : Controller
    {
        tercuman_dbEntities db = new tercuman_dbEntities();
        // GET: Calisan
        public ActionResult Index()
        {
            var siparisler = db.Tbl_Metin.ToList();
            return View(siparisler);
        }
        public ActionResult Goruntule(int id)
        {
            var siparis = db.Tbl_Metin.Find(id);
            return View(siparis);
        }
        [HttpGet]
        public ActionResult Cevir(int id)
        {
            var ceviri = db.Tbl_Metin.Find(id);
            return View(ceviri);
        }
        [HttpPost]
        public ActionResult Cevir(Tbl_Metin t)
        {
            var sprs = db.Tbl_Metin.Find(t.Id);
            sprs.Cev_metin = t.Cev_metin;
            sprs.Tam_onay = true;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult CeviriGoruntule(int id)
        {
            var siparis = db.Tbl_Metin.Find(id);
            return View(siparis);
        }
    }
}