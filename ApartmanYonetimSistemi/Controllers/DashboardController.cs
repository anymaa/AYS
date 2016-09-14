using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ApartmanYonetimSistemi.Attributes;
using ApartmanYonetimSistemi.Models;

namespace ApartmanYonetimSistemi.Controllers
{

    public class DashboardController : Controller
    {
        ApartmanYonetimSistemiEntities db = new ApartmanYonetimSistemiEntities();


        // GET: Dashboard
        [Authorized]
        public ActionResult Index()
        {
                return View();  
        }

        [Authorized]
        public ActionResult Aidatlar()
        {
            //var borcEkle = new BorcEkle();
            //ViewData.Model = db.BorcEkles.ToList();
            //var borc = (from b in db.BorcEkles
            //           select b).ToList();

            return View(db.BorcEkles);
        }

        //public class BorcEkle : DbContext

        //{

        //    public DbSet<BorcEkle> BorcEkles { get; set; }

        //}

        public ActionResult BorcEkle()
        {
            return View();
        }

    }
}