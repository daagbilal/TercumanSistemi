using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TercumanSistemi.Models.EntityFramework;
using System.Web.Security;

namespace TercumanSistemi.Controllers
{
    public class CalisanLoginController : Controller
    {
        tercuman_dbEntities db = new tercuman_dbEntities();
        // GET: CalisanLogin
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Tbl_Calisan t)
        {
            var bilgiler = db.Tbl_Calisan.FirstOrDefault(x => x.Eposta == t.Eposta && x.Sifre == t.Sifre);
            if (bilgiler != null)
            {
                FormsAuthentication.SetAuthCookie(bilgiler.Eposta, false);
                Session["KullaniciId"] = bilgiler.Id;
                return RedirectToAction("Index", "Calisan");
            }
            else
            {
                return View();
            }
        }
    }
}