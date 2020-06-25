using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Ozellikler : Attribute
    {
        public string PrimaryKey { get; set; }
        public string StringerBir { get; set; }
        public string StringerIki { get; set; }
        public string StringerUc { get; set; }
        public string YoxlananKolon { get; set; }
    }
}
