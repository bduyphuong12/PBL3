//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class CHI_TIET_THONG_KE
    {
        public int ID { get; set; }
        public string MaDonHang { get; set; }
        public string MaSanPham { get; set; }
        public Nullable<int> SoLuong { get; set; }
        public Nullable<int> GiaBan { get; set; }
        public Nullable<int> GiaNhap { get; set; }
    
        public virtual THONG_KE THONG_KE { get; set; }
    }
}
