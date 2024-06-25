using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TercumanSistemi.Models.EntityFramework;

namespace TercumanSistemi.Controllers
{
    public class MusteriController : Controller
    {
        tercuman_dbEntities db = new tercuman_dbEntities();
        
        // GET: Musteri
        public ActionResult Index()
        {
            var siparisler = db.Tbl_Metin.ToList();
            return View(siparisler);
        }
        [HttpGet]
        public ActionResult Olustur()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Olustur(Tbl_Metin t)
        {
            t.Musteri_id = Convert.ToInt32(Session["MusteriId"]);
            t.Onay = false;
            t.Tam_onay = false;
            db.Tbl_Metin.Add(t);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Goruntule(int id)
        {
            var metin = db.Tbl_Metin.Find(id);
            return View(metin);
        }
    }
}