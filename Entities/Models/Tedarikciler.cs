using System;
using System.Collections.Generic;

namespace Entities.Models
{
    [Ozellikler(PrimaryKey = "TedarikciId")]
    public class Tedarikciler
    {
        public Tedarikciler()
        {

        }
        public int TedarikciId { get; set; }
        public int IletisimID { get; set; }
        public Nullable<bool> Sonlandi { get; set; }
    }
}
