//------------------------------------------------------------------------------
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
    using System.Collections.Generic;

    public partial class HOADONTHUEPHONG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HOADONTHUEPHONG()
        {
            this.LICHSUTHEMDICHVUs = new HashSet<LICHSUTHEMDICHVU>();
        }

        public int MaHoaDon { get; set; }
        public System.DateTime ThoiGianThue { get; set; }
        public Nullable<System.DateTime> ThoiGianTra { get; set; }
        public Nullable<double> TongTien { get; set; }
        public int NhanVienTaoHoaDon { get; set; }
        public string Phong { get; set; }
        public Nullable<int> MaKhachHang { get; set; }
        public System.DateTime NgayTao { get; set; }

        public virtual KHACHHANG KHACHHANG { get; set; }
        public virtual NHANVIEN NHANVIEN { get; set; }
        public virtual PHONG PHONG1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LICHSUTHEMDICHVU> LICHSUTHEMDICHVUs { get; set; }
    }
}
