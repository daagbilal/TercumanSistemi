using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TercumanSistemi.Models.EntityFramework;
using System.Web.Security;

namespace TercumanSistemi.Controllers
{
    public class AdminLoginController : Controller
    {
        tercuman_dbEntities db = new tercuman_dbEntities();
        // GET: AdminLogin
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Tbl_Yonetici t)
        {
            var bilgiler = db.Tbl_Yonetici.FirstOrDefault(x => x.Eposta == t.Eposta && x.Sifre == t.Sifre);
            if (bilgiler != null)
            {
                FormsAuthentication.SetAuthCookie(bilgiler.Eposta, false);
                return RedirectToAction("Index", "Admin");
            }
            else
            {
                return View();
            }
        }
    }
}