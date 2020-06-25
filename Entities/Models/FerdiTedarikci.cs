using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    [Ozellikler(StringerBir = "Soyad", StringerIki = "SexsiyyetNo", StringerUc = "Adi",YoxlananKolon="Adi")]
    public class FerdiTedarikci
    {
        public int TedarikciID { get; set; }
        public string Soyad { get; set; }
        public string SexsiyyetNo { get; set; }
        public string Adi { get; set; }
    }
}
