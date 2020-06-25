using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    [Ozellikler(PrimaryKey="IsciId")]
    public class Iskiler
    {
        public string IsciAdi { get; set; }
        public string Soyadi { get; set; }
        public DateTime Dogum { get; set; }
        public decimal Maas { get; set; }
        public int IsciId { get; set; }
        public int IletisimID { get; set; }
        public string IsciResim { get; set; }
    }
}
