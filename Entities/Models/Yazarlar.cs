using System;
using System.Collections.Generic;

namespace Entities.Models
{
    [Ozellikler(PrimaryKey = "Id",YoxlananKolon = "YazarAdi", StringerIki = "YazarSoyAdi")]
    public class Yazarlar
    {
        public int Id { get; set; }
        public string YazarAdi { get; set; }
        public string YazarSoyAdi { get; set; }
        public string Haqqinda { get; set; }
        public string Resim { get; set; }
        public Nullable<int> IletisimID { get; set; }
        public Nullable<bool> Sonlandi { get; set; }
    }
}
