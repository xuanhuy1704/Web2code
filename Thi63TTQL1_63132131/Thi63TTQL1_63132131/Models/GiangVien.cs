//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Thi63TTQL1_63132131.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class GiangVien
    {
        public string MaGV { get; set; }
        public string HoGV { get; set; }
        public string TenGV { get; set; }
        public Nullable<System.DateTime> NgaySinh { get; set; }
        public Nullable<bool> GioiTinh { get; set; }
        public string Email { get; set; }
        public string AnhGV { get; set; }
        public string MaBM { get; set; }
    
        public virtual BoMon BoMon { get; set; }
    }
}
