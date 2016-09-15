using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ApartmanYonetimSistemi.Attributes;
using ApartmanYonetimSistemi.Models;

namespace ApartmanYonetimSistemi.Controllers
{
    public class AccountController : BaseController
    {
        // GET: Account
        private ApartmanYonetimSistemiEntities db = new ApartmanYonetimSistemiEntities();
        private SessionModel sm = new SessionModel();

        public ActionResult Login()
        {
            return View();
        }


        public ActionResult SignIn()
        {
                var USERNAME = Request.Form["username"];
                var PASSWORD = Request.Form["password"];

                var data = db.TBLUSERS.FirstOrDefault(x => x.USERNAME == USERNAME && x.PASSWORD == PASSWORD);
                if (data != null)
                {
                    sm.User = data;
                    sm.Save();
                    Session["Member"] = sm;

                    if (db.TBLADDDEBT.Count(x => x.USERID == data.USERID) == 0)
                    {
                        return RedirectToAction("Index", "Dashboard");
                    }
                    return RedirectToAction("Index", "Dashboard");
                }

                Session["hidealert"] = "show";

                return RedirectToAction("Login", "Account");
          }

        public ActionResult SignOut()
        {
            sm.Remove();
            return RedirectToAction("Login", "Account");
        }
    }
}