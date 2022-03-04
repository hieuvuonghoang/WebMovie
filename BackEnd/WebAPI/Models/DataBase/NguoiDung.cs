using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebAPI.Models.DataBase
{
    public partial class NguoiDung
    {
        public NguoiDung()
        {
            BinhLuan = new HashSet<BinhLuan>();
        }

        public Guid NguoiDungId { get; set; }
        public string TenDangNhap { get; set; }
        public string MatKhau { get; set; }
        public string Email { get; set; }
        public string TrangThaiHoatDong { get; set; }
        public string HoVaTen { get; set; }
        public byte[] AnhDaiDien { get; set; }

        public virtual ICollection<BinhLuan> BinhLuan { get; set; }
    }
}
