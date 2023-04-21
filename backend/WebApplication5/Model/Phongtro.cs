using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication5.Model
{
    public partial class Phongtro
    {
        public Phongtro()
        {
            Userdatphongs = new HashSet<Userdatphong>();
        }

        public int Maphong { get; set; }
        public string Hinhanh1 { get; set; }
        public string Hinhanh2 { get; set; }
        public string Hinhanh3 { get; set; }
        public double? Gia { get; set; }
        public string Loai { get; set; }
        public int? Phongngu { get; set; }
        public int? Nhatam { get; set; }
        public bool? Wifi { get; set; }
        public bool? Maylanh { get; set; }
        public double? Dientich { get; set; }
        public string Diachi { get; set; }
        public bool? Guixe { get; set; }
        public bool? Conphong { get; set; }
        public string Mota { get; set; }

        public virtual ICollection<Userdatphong> Userdatphongs { get; set; }
    }
}
