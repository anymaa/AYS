using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ApartmanYonetimSistemi.Models;

namespace ApartmanYonetimSistemi.Controllers
{
    public class BaseController : Controller
    {
        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var session = Session["Member"] as SessionModel;
            var action = filterContext.RouteData.GetRequiredString("action");
            var controller = filterContext.RouteData.GetRequiredString("controller");

            //if (session == null && controller != "SignIn")
            //{
            //    filterContext.Result = RedirectToAction("Login", "Account");
            //    return;
            //}
        }
    }

    public class SessionModel
    {
        public TBLUSERS User { get; set; }
        public static SessionModel Current
        {
            get
            {
                return HttpContext.Current.Session["Member"] as SessionModel;
            }
        }
        public void Save()
        {
            HttpContext.Current.Session["Member"] = this;
        }
        public void Remove()
        {
            HttpContext.Current.Session["Member"] = null;
        }
    }


}