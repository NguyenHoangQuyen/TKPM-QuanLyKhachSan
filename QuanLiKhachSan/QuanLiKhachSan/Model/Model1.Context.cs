﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLiKhachSan.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class QLKHACHSANEntities : DbContext
    {
        public QLKHACHSANEntities()
            : base("name=QLKHACHSANEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<BANGTHAMSO> BANGTHAMSOes { get; set; }
        public virtual DbSet<DICHVU> DICHVUs { get; set; }
        public virtual DbSet<HOADONTHUEPHONG> HOADONTHUEPHONGs { get; set; }
        public virtual DbSet<KHACHHANG> KHACHHANGs { get; set; }
        public virtual DbSet<LICHSUTHEMDICHVU> LICHSUTHEMDICHVUs { get; set; }
        public virtual DbSet<LOAIDV> LOAIDVs { get; set; }
        public virtual DbSet<LOAINHANVIEN> LOAINHANVIENs { get; set; }
        public virtual DbSet<LOAIPHONG> LOAIPHONGs { get; set; }
        public virtual DbSet<NHANVIEN> NHANVIENs { get; set; }
        public virtual DbSet<NVKETOAN> NVKETOANs { get; set; }
        public virtual DbSet<NVLETAN> NVLETANs { get; set; }
        public virtual DbSet<NVQUANLI> NVQUANLIs { get; set; }
        public virtual DbSet<PHONG> PHONGs { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
    }
}
