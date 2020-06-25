using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    [Ozellikler(PrimaryKey="Id")]
    public class IsciSistemMelumat
    {
        public int Id { get; set; }
        public int IsciID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Rol { get; set; }
        public DateTime QeydiyyatTarixi { get; set; }
    }
}
