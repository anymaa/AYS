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
    
    public partial class TBLUSERS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBLUSERS()
        {
            this.TBLADDCOST = new HashSet<TBLADDCOST>();
            this.TBLADDDEBT = new HashSet<TBLADDDEBT>();
        }
    
        public int USERID { get; set; }
        public string USERNAME { get; set; }
        public string PASSWORD { get; set; }
        public string EMAIL { get; set; }
        public bool ISACTIVE { get; set; }
        public string NAME { get; set; }
        public string SURNAME { get; set; }
        public string PHONE { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLADDCOST> TBLADDCOST { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLADDDEBT> TBLADDDEBT { get; set; }
    }
}
