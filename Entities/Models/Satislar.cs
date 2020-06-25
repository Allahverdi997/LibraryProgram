using System;
using System.Collections.Generic;

namespace Entities.Models
{
    [Ozellikler(PrimaryKey = "Id")]
    public class Satislar
    {
        public int Id { get; set; }
        public int IsciID { get; set; }
        public int MusteriID { get; set; }
        public int KitabID { get; set; }
        public int KargoID { get; set; }
        public DateTime SatisTarihi { get; set; }
    }
}
