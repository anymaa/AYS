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
    
    public partial class TBLADDDEBT
    {
        public int TABLEID { get; set; }
        public bool ISACTIVE { get; set; }
        public bool DELETE { get; set; }
        public System.DateTime CREATEDATE { get; set; }
        public int USERID { get; set; }
        public int BUILDINGID { get; set; }
        public int STATUSID { get; set; }
        public System.DateTime START { get; set; }
        public System.DateTime FINISH { get; set; }
        public string NAME { get; set; }
        public string EXPLANATION { get; set; }
    }
}
