﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KT0720Huy_63132131.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class KT0720_63132131Entities : DbContext
    {
        public KT0720_63132131Entities()
            : base("name=KT0720_63132131Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Lop> Lops { get; set; }
        public virtual DbSet<SinhVien> SinhViens { get; set; }
    
        public virtual int SinhVien_TimKiem(string maSV, string hoTen)
        {
            var maSVParameter = maSV != null ?
                new ObjectParameter("MaSV", maSV) :
                new ObjectParameter("MaSV", typeof(string));
    
            var hoTenParameter = hoTen != null ?
                new ObjectParameter("HoTen", hoTen) :
                new ObjectParameter("HoTen", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SinhVien_TimKiem", maSVParameter, hoTenParameter);
        }
    }
}
