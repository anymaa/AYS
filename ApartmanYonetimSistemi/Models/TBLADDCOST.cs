//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ApartmanYonetimSistemi.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TBLADDCOST
    {
        public int TABLEID { get; set; }
        public int USERID { get; set; }
        public string EXPLANATION { get; set; }
        public decimal AMOUNT { get; set; }
        public System.DateTime DATEOFISSUE { get; set; }
        public System.DateTime DUEDATE { get; set; }
        public bool PAYSTATUS { get; set; }
        public Nullable<int> CATEGORYID { get; set; }
        public bool ISACTIVE { get; set; }
        public System.DateTime REGDATE { get; set; }
    
        public virtual TBLCATEGORY TBLCATEGORY { get; set; }
        public virtual TBLUSERS TBLUSERS { get; set; }
    }
}
