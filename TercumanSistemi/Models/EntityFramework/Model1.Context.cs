﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TercumanSistemi.Models.EntityFramework
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class tercuman_dbEntities : DbContext
    {
        public tercuman_dbEntities()
            : base("name=tercuman_dbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Tbl_Calisan> Tbl_Calisan { get; set; }
        public virtual DbSet<Tbl_Mesaj> Tbl_Mesaj { get; set; }
        public virtual DbSet<Tbl_Metin> Tbl_Metin { get; set; }
        public virtual DbSet<Tbl_Musteri> Tbl_Musteri { get; set; }
        public virtual DbSet<Tbl_Yonetici> Tbl_Yonetici { get; set; }
    }
}
