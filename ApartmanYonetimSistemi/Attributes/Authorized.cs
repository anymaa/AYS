using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ApartmanYonetimSistemi.Attributes
{
    public class Authorized : ActionFilterAttribute
    {
        //public override void OnActionExecuting(ActionExecutingContext filterContext)
        //{
        //    if (HttpContext.Current.Session["Login"].ToString() == "0")
        //    {
 
        //        filterContext.HttpContext.Response.Redirect("~/Account/Login");
        //    }
        //    base.OnActionExecuting(filterContext);
        //}
    }
}