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

    public class DashboardController : BaseController
    {
        ApartmanYonetimSistemiEntities db = new ApartmanYonetimSistemiEntities();


        // GET: Dashboard
        [Authorized]
        public ActionResult Index()
        {


            return View();  
        }

        public PartialViewResult Menu()
        {
 

            return PartialView();
        }

        [Authorized]
        public ActionResult Aidatlar()
        {
            //var borcEkle = new BorcEkle();
            //ViewData.Model = db.BorcEkles.ToList();
            //var borc = (from b in db.BorcEkles
            //            select b).ToList();
            var addDebt = db.TBLADDDEBT;

            return View(addDebt);
        }

        //public class BorcEkle : DbContext

        //{

        //    public DbSet<BorcEkle> BorcEkles { get; set; }

        //}

        public ActionResult BorcEkle()
        {
            return View();
        }

        // GET: Profil
        public ActionResult Profil()
        {
            return View();
        }

    }
}