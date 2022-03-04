using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebAPI.Models.DataBase
{
    public partial class Tap
    {
        public Tap()
        {
            TapBinhLuan = new HashSet<TapBinhLuan>();
        }

        public Guid TapId { get; set; }
        public int TapSo { get; set; }
        public string DuongDan { get; set; }
        public DateTime ThoiGianKhoiTao { get; set; }

        public virtual PhimTap PhimTap { get; set; }
        public virtual ICollection<TapBinhLuan> TapBinhLuan { get; set; }
    }
}
