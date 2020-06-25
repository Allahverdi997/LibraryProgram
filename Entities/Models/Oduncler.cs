using System;
using System.Collections.Generic;

namespace Entities.Models
{
    [Ozellikler(PrimaryKey = "Id")]
    public class Oduncler
    {
        public int Id { get; set; }
        public int IsciID { get; set; }
        public int KitabID { get; set; }
        public int MusteriID { get; set; }
        public DateTime VerilmeTarihi { get; set; }
        public DateTime QaytarilmaTarihi { get; set; }
        public bool TeslimDurumu { get; set; }
    }
}
