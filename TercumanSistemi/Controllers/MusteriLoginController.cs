using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TercumanSistemi.Models.EntityFramework;
using System.Web.Security;

namespace TercumanSistemi.Controllers
{
    public class MusteriLoginController : Controller
    {
        tercuman_dbEntities db = new tercuman_dbEntities();
        // GET: MusteriLogin
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Tbl_Musteri t)
        {
            var bilgiler = db.Tbl_Musteri.FirstOrDefault(x => x.Eposta == t.Eposta && x.Sifre == t.Sifre);
            if (bilgiler != null)
            {
                FormsAuthentication.SetAuthCookie(bilgiler.Eposta, false);
                Session["MusteriId"] = bilgiler.Id;
                return RedirectToAction("Index", "Musteri");
            }
            else
            {
                return View();
            }
        }
    }
}