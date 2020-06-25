using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Tools
{
    public class Execute
    {
        public static bool ExecuteNonQuery(SqlCommand cmd)
        {
            if (Tools.Connection.Baglanti.State == ConnectionState.Closed)
            {
                Tools.Connection.Baglanti.Open();
            }
            try
            {
                int etk = cmd.ExecuteNonQuery();
                if (etk > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                if (Tools.Connection.Baglanti.State == ConnectionState.Open)
                {
                    Tools.Connection.Baglanti.Close();
                }
            }
        }
    }
}
