using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Tools
{
    public class AditionTools<ET> where ET:class
    {
        public static string PKGetir()
        {
            string pk = "";
            var ozellikler = typeof(ET).GetCustomAttributes(typeof(Ozellikler), false);
            if (ozellikler != null && ozellikler.Any())
            {
                Ozellikler ozellik = (Ozellikler)ozellikler[0];
                pk = ozellik.PrimaryKey;
            }
            return pk;
        }

        public static string YoxlananGetir()
        {
            string yoxlanan = "";
            var ozellikler = typeof(ET).GetCustomAttributes(typeof(Ozellikler), false);
            if (ozellikler != null && ozellikler.Any())
            {
                Ozellikler ozellik = (Ozellikler)ozellikler[0];
                yoxlanan = ozellik.YoxlananKolon;
            }
            return yoxlanan;
        }
    }
}
