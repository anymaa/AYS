using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ApartmanYonetimSistemi.Attributes;
using ApartmanYonetimSistemi.Models;

namespace ApartmanYonetimSistemi.Controllers
{
    public class ProfilController : BaseController
    {
        // GET: Profil
        public ActionResult Profil()
        {
            return View();
        }
    }
}