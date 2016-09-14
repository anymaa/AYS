using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace ApartmanYonetimSistemi.Models
{
    public class MainModel
    {

        public IEnumerable<BorcEkle> BorcEkles { get; set; }
        public IEnumerable<User> Users { get; set; }



        //public static MainModel Current
        //{
        //    get
        //    {
        //        return HttpContext.Current.Session["Member"] as MainModel;
        //    }
        //}

        //public void Save()
        //{
        //    HttpContext.Current.Session["Member"] = this;
        //}

        //public void Remove()
        //{
        //    HttpContext.Current.Session["Member"] = null;
        //}
    }
}