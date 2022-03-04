using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebAPI.Models.DataBase
{
    public partial class BinhLuan
    {
        public Guid BinhLuanId { get; set; }
        public Guid NguoiDungId { get; set; }
        public DateTime ThoiGianKhoiTao { get; set; }
        public string NoiDung { get; set; }

        public virtual NguoiDung NguoiDung { get; set; }
        public virtual PhimBinhLuan PhimBinhLuan { get; set; }
        public virtual TapBinhLuan TapBinhLuan { get; set; }
    }
}
