﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sikayet
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class MusteriSikayetEntities : DbContext
    {
        public MusteriSikayetEntities()
            : base("name=MusteriSikayetEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Sikayet_Tablo> Sikayet_Tablo { get; set; }
        public virtual DbSet<SilinenKayitlar> SilinenKayitlar { get; set; }
        public virtual DbSet<Userss> Userss { get; set; }
    }
}
