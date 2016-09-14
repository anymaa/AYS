using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ApartmanYonetimSistemi.Attributes;
using ApartmanYonetimSistemi.Models;

namespace ApartmanYonetimSistemi.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        ApartmanYonetimSistemiEntities db = new ApartmanYonetimSistemiEntities();
        [Authorized]
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(FormCollection form)
        {
            string username = form["username"].ToString();
            string password = form["password"].ToString();

            var usr = (from u in db.Users
                where u.Username == username && u.Password == password
                select u).FirstOrDefault();

            if (usr != null)
            {
                Session["Login"] = "1";
                return RedirectToAction("Index", "Dashboard");
            }
            else
            {
                Session["Login"] = "0";
            }

            TempData["Message"] = "Username and password is wrong";
            return View();
        }
    }
}