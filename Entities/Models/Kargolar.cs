using System;
using System.Collections.Generic;

namespace Entities.Models
{
    [Ozellikler(PrimaryKey = "Id", StringerBir = "KargoAd", YoxlananKolon = "KargoAd")]
    public class Kargolar
    {
        public int Id { get; set; }
        public int IletisimID { get; set; }
        public string KargoAd { get; set; }
    }
}
