﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ApartmanYonetimSistemiEntities : DbContext
    {
        public ApartmanYonetimSistemiEntities()
            : base("name=ApartmanYonetimSistemiEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<TBLADDDEBT> TBLADDDEBT { get; set; }
        public virtual DbSet<TBLCATEGORY> TBLCATEGORY { get; set; }
        public virtual DbSet<TBLUSERS> TBLUSERS { get; set; }
    }
}
