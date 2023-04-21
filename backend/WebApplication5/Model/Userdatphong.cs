using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication5.Model
{
    public partial class Userdatphong
    {
        public int Maphong { get; set; }
        public int Mauser { get; set; }
        public string Tenuser { get; set; }
        public string Sodienthoai { get; set; }
        public string Email { get; set; }

        public virtual Phongtro MaphongNavigation { get; set; }
        public virtual User MauserNavigation { get; set; }
    }
}
