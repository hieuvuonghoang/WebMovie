using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebAPI.Models.DataBase
{
    public partial class DaoDien
    {
        public DaoDien()
        {
            PhimDaoDien = new HashSet<PhimDaoDien>();
        }

        public Guid DaoDienId { get; set; }
        public string TenDaoDien { get; set; }

        public virtual ICollection<PhimDaoDien> PhimDaoDien { get; set; }
    }
}
