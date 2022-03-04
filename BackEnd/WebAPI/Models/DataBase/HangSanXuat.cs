using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebAPI.Models.DataBase
{
    public partial class HangSanXuat
    {
        public HangSanXuat()
        {
            PhimHangSanXuat = new HashSet<PhimHangSanXuat>();
        }

        public Guid HangSanXuatId { get; set; }
        public string TenHangSanXuat { get; set; }

        public virtual ICollection<PhimHangSanXuat> PhimHangSanXuat { get; set; }
    }
}
