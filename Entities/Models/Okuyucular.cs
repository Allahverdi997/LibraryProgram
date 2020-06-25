using System;
using System.Collections.Generic;

namespace Entities.Models
{
    [Ozellikler(PrimaryKey = "Id",YoxlananKolon = "SexsiyyetNo", StringerIki = "OkuyucuSoyad", StringerUc = "SexsiyyetNo")]
    public class Okuyucular
    {
        public int Id { get; set; }
        public string OkuyucuAdi { get; set; }
        public string OkuyucuSoyad { get; set; }
        public DateTime DogumTarihi { get; set; }
        public bool Cinsiyyet { get; set; }
        public DateTime QeydiyyatTarixi { get; set; }
        public int IletisimID { get; set; }
        public string SexsiyyetNo { get; set; }
    }
}
