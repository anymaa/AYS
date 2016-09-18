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

            return View();
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

            addDebt.CATEGORYID = KategoriEkle(kategori);

            addDebt.ISACTIVE = true;
            addDebt.REGDATE = DateTime.Now;
            addDebt.USERID = SessionModel.Current.User.USERID;
            tempDebt = addDebt;


            db.TBLADDDEBT.Add(addDebt);
            db.SaveChanges();

            return View();
        }

        public int KategoriEkle(string kategori)
        {
            var dataCategory = db.TBLCATEGORY;
            var addData = new TBLCATEGORY();

            foreach (var item in dataCategory)
            {
                if (kategori == item.CATEGORYNAME)
                {
                    return item.CATEGORYID;
                    db.TBLCATEGORY.Add(addData);
                }
            }


            db.TBLCATEGORY.Add(addData);
            addData.CATEGORYNAME = kategori;
            return addData.CATEGORYID;
        }

        // GET: Profil
        public ActionResult Profil()
        {
            return View();
        }

    }
}