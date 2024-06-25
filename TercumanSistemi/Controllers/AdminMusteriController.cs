using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TercumanSistemi.Models.EntityFramework;

namespace TercumanSistemi.Controllers
{
    public class AdminMusteriController : Controller
    {
        tercuman_dbEntities db = new tercuman_dbEntities();
        // GET: AdminMusteri
        public ActionResult Index()
        {
            var musteriler = db.Tbl_Musteri.ToList();
            return View(musteriler);
        }
    }
}