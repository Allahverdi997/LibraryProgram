using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    [Ozellikler(StringerBir = "SirketAdi", YoxlananKolon = "Voen", StringerUc = "PersonelAd")]
    public class SirketTedarikci
    {
        public int TedarikciID { get; set; }
        public string SirketAdi { get; set; }
        public string Voen { get; set; }
        public string PersonelAd { get; set; }
    }
}
