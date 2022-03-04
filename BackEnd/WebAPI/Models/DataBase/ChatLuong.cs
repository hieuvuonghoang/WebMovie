using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebAPI.Models.DataBase
{
    public partial class ChatLuong
    {
        public ChatLuong()
        {
            Phim = new HashSet<Phim>();
        }

        public Guid ChatLuongId { get; set; }
        public string TenChatLuong { get; set; }

        public virtual ICollection<Phim> Phim { get; set; }
    }
}
