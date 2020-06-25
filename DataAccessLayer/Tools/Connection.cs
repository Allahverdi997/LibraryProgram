using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace DataAccessLayer.Tools
{
    public class Connection
    {
        private static SqlConnection baglanti;

        public static SqlConnection  Baglanti
        {
            get 
            {
                if (baglanti==null)
                {
                    baglanti = new SqlConnection(ConfigurationManager.ConnectionStrings["LibraryConnection"].ConnectionString);
                }
                return baglanti; 
            }
            set { baglanti = value; }
        }
    }
}
