﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PBL3.DTO
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class PBL3_DATABASE : DbContext
    {
        public PBL3_DATABASE()
            : base("name=PBL3_DATABASE")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CHI_TIET_DON_HANG> CHI_TIET_DON_HANG { get; set; }
        public virtual DbSet<CHI_TIET_SAN_PHAM> CHI_TIET_SAN_PHAM { get; set; }
        public virtual DbSet<CHI_TIET_THONG_KE> CHI_TIET_THONG_KE { get; set; }
        public virtual DbSet<HOA_DON> HOA_DON { get; set; }
        public virtual DbSet<KHACH_HANG> KHACH_HANG { get; set; }
        public virtual DbSet<NHAN_VIEN> NHAN_VIEN { get; set; }
        public virtual DbSet<PHAN_QUYEN> PHAN_QUYEN { get; set; }
        public virtual DbSet<SAN_PHAM> SAN_PHAM { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<THONG_KE> THONG_KE { get; set; }
    }
}