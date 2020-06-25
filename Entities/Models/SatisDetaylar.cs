using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public class SatisDetaylar
    {
        public int SatisID { get; set; }
        public short Miktar { get; set; }
        public decimal SatisFiyat { get; set; }
        public double Indirim { get; set; }
    }
}
