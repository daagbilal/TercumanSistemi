using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TercumanSistemi.Models.EntityFramework;

namespace TercumanSistemi.Controllers
{
    public class AdminController : Controller
    {
        tercuman_dbEntities db = new tercuman_dbEntities();
        // GET: Admin
        public ActionResult Index()
        {
            var sparisler = db.Tbl_Metin.ToList();
            return View(sparisler);
        }
        [HttpGet]
        public ActionResult Onayla(int id)
        {
            List<SelectListItem> calisanlar = (from i in db.Tbl_Calisan.ToList()
                                               where i.Durum == true
                                             select new SelectListItem
                                             {
                                                 Text = $"{i.Ad} {i.Soyad}",
                                                 Value = i.Id.ToString()
                                             }).ToList();
            ViewBag.calisanlar = calisanlar;
            var siparis = db.Tbl_Metin.Find(id);
            return View("Onayla", siparis);
        }
        [HttpPost]
        public ActionResult Onayla(Tbl_Metin t)
        {
            var guncelle = db.Tbl_Metin.Find(t.Id);
            guncelle.Calisan_id = t.Calisan_id;
            guncelle.Onay = true;
            guncelle.Tam_onay = false;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Tamamla()
        {
            return View();
        }
        public ActionResult Goruntule(int id)
        {
            var siparis = db.Tbl_Metin.Find(id);
            return View(siparis);
        }
    }
}