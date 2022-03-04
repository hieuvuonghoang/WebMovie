using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebAPI.Models.DataBase
{
    public partial class DanhGia
    {
        public DanhGia()
        {
            PhimDanhGia = new HashSet<PhimDanhGia>();
        }

        public Guid DanhGiaId { get; set; }
        public int DiemDanhGia { get; set; }
        public string NoiDung { get; set; }

        public virtual ICollection<PhimDanhGia> PhimDanhGia { get; set; }
    }
}
