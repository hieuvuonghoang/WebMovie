using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebAPI.Models.DataBase
{
    public partial class PhimBinhLuan
    {
        public Guid PhimBinhLuanId { get; set; }
        public Guid PhimId { get; set; }
        public Guid BinhLuanId { get; set; }

        public virtual BinhLuan BinhLuan { get; set; }
        public virtual Phim Phim { get; set; }
    }
}
