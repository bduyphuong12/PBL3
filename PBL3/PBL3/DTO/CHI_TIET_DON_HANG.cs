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
    
    public partial class CHI_TIET_DON_HANG
    {
        public int ID { get; set; }
        public string MaDonHang { get; set; }
        public string MaSanPham { get; set; }
        public Nullable<int> SoLuong { get; set; }
        public string MaKhachHang { get; set; }
        public Nullable<int> TongTien { get; set; }
    
        public virtual HOA_DON HOA_DON { get; set; }
        public virtual KHACH_HANG KHACH_HANG { get; set; }
        public virtual SAN_PHAM SAN_PHAM { get; set; }
    }
}
