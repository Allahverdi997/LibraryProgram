using System;
using System.Collections.Generic;

namespace Entities.Models
{
    [Ozellikler(PrimaryKey = "Id",YoxlananKolon="KategoriAdi",StringerIki="KategoriAciklamasi")]
    public class Kategoriler
    {
        public int Id { get; set; }
        public string KategoriAdi { get; set; }
        public string KategoriAciklamasi { get; set; }
        public string KategoriResim { get; set; }
    }
}
