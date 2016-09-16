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

        [HttpPost]
        public ActionResult BorcEkle(TBLADDDEBT tempDebt, string aciklama, string hesap, decimal tutar, DateTime start, DateTime end , string kategori)
        {
            var addDebt = new TBLADDDEBT();
            addDebt.EXPLANATION = aciklama;
            addDebt.BILLACCUNT = hesap;
            addDebt.AMOUNT = tutar;
            addDebt.DATEOFISSUE = start;
            addDebt.DUEDATE = end;
            addDebt.TBLCATEGORY.CATEGORYNAME = kategori;
            addDebt.CATEGORYID = addDebt.TBLCATEGORY.CATEGORYID;
            addDebt.ISACTIVE = true;
            addDebt.REGDATE = DateTime.Now;
            addDebt.USERID = SessionModel.Current.User.USERID;
            //addDebt.EXPLANATION = form["Aciklama"].Trim();
            //addDebt.BILLACCUNT = form["Hesap"].Trim();
            //addDebt.AMOUNT = Convert.ToDecimal(form["Hesap"].Trim());
            //addDebt.DATEOFISSUE = Convert.ToDateTime(form["daterangepicker_start"]);
            //addDebt.DUEDATE = Convert.ToDateTime(form["daterangepicker_end"]);
            //addDebt.TBLCATEGORY.CATEGORYNAME = form["Kategori"]; 

            db.TBLADDDEBT.Add(addDebt);
            db.SaveChanges();

            return RedirectToAction("Aidatlar" , "Dashboard");
        }

        // GET: Profil
        public ActionResult Profil()
        {
            return View();
        }

    }
}