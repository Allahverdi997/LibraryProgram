using System;
using System.Collections.Generic;

namespace Entities.Models
{
    [Ozellikler(PrimaryKey = "Id",YoxlananKolon= "Adi", StringerIki = "Soyadi", StringerUc = "SexsiyyetNo")]
    public class Musteriler
    {
        public int Id { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string SexsiyyetNo { get; set; }
        public int IletisimID { get; set; }
    }
}
