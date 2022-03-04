using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebAPI.Models.DataBase
{
    public partial class Phim
    {
        public Phim()
        {
            PhimBinhLuan = new HashSet<PhimBinhLuan>();
            PhimDanhGia = new HashSet<PhimDanhGia>();
            PhimDanhMuc = new HashSet<PhimDanhMuc>();
            PhimHangSanXuat = new HashSet<PhimHangSanXuat>();
            PhimTap = new HashSet<PhimTap>();
        }

        public Guid PhimId { get; set; }
        public string TenPhim { get; set; }
        public int SoTap { get; set; }
        public string DuongDanAnhBia { get; set; }
        public int UuTienHienThi { get; set; }
        public string MoTa { get; set; }
        public string IsActive { get; set; }
        public int LuotXem { get; set; }
        public Guid ChatLuongId { get; set; }
        public DateTime ThoiGianKhoiTao { get; set; }

        public virtual ChatLuong ChatLuong { get; set; }
        public virtual PhimDaoDien PhimDaoDien { get; set; }
        public virtual ICollection<PhimBinhLuan> PhimBinhLuan { get; set; }
        public virtual ICollection<PhimDanhGia> PhimDanhGia { get; set; }
        public virtual ICollection<PhimDanhMuc> PhimDanhMuc { get; set; }
        public virtual ICollection<PhimHangSanXuat> PhimHangSanXuat { get; set; }
        public virtual ICollection<PhimTap> PhimTap { get; set; }
    }
}
