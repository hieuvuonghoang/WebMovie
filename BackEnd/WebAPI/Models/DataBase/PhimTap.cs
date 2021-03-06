using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebAPI.Models.DataBase
{
    public partial class PhimTap
    {
        public Guid PhimTapId { get; set; }
        public Guid PhimId { get; set; }
        public Guid TapId { get; set; }

        public virtual Phim Phim { get; set; }
        public virtual Tap Tap { get; set; }
    }
}
