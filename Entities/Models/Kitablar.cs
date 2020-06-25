using System;
using System.Collections.Generic;

namespace Entities.Models
{
    [Ozellikler(PrimaryKey = "Id", YoxlananKolon = "BarkodNo", StringerIki = "KitabAdi", StringerUc = "YayinEvi")]
    public class Kitablar
    {
        public int Id { get; set; }
        public int YazarID { get; set; }
        public int KategoriID { get; set; }
        public int TedarikciID { get; set; }
        public string BarkodNo { get; set; }
        public string KitabAdi { get; set; }
        public string KitabAciklamasi { get; set; }
        public int VereqSayi { get; set; }
        public decimal Fiyati { get; set; }
        public short Miktar { get; set; }
        public string YayinEvi { get; set; }
        public string KitabResim { get; set; }
        public Nullable<DateTime> TeminTarihi { get; set; }
        public Nullable<bool> Sonlandi { get; set; }
    }
}
