using System;
using System.Collections.Generic;

namespace Entities.Models
{
    [Ozellikler(PrimaryKey = "Id", StringerBir = "TelefonNo", StringerIki = "Adresi", StringerUc = "WebSitesi")]
    public class Iletisimler
    {
        public int Id { get; set; }
        public string TelefonNo { get; set; }
        public string Adresi { get; set; }
        public string WebSitesi { get; set; }
        public string PostaKodu { get; set; }
    }
}
