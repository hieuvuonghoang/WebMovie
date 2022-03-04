using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebAPI.Models.DataBase
{
    public partial class DanhMuc
    {
        public DanhMuc()
        {
            PhimDanhMuc = new HashSet<PhimDanhMuc>();
        }

        public Guid DanhMucId { get; set; }
        public string TenDanhMuc { get; set; }
        public int UuTienHienThi { get; set; }
        public string IsActive { get; set; }

        public virtual ICollection<PhimDanhMuc> PhimDanhMuc { get; set; }
    }
}
