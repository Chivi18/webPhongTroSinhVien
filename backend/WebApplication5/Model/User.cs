using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication5.Model
{
    public partial class User
    {
        public User()
        {
            Userdatphongs = new HashSet<Userdatphong>();
        }

        public int Mauser { get; set; }
        public string Tenuser { get; set; }
        public string Password { get; set; }
        public string Sodienthoai { get; set; }
        public string Email { get; set; }
        public string Anhdaidien { get; set; }
        public string Diachiuser { get; set; }
        public string Quyenhan { get; set; }

        public virtual ICollection<Userdatphong> Userdatphongs { get; set; }
    }
}
