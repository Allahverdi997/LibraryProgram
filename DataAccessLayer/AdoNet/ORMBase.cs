using DataAccessLayer.Tools;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.AdoNet
{
    public class ORMBase<ET>:IORM<ET> where ET:class
    {
        private ORMBase()
        {

        }

        private static ORMBase<ET> _instance;

        public static ORMBase<ET> InstanceGetir()
        {
            if (_instance==null)
            {
                _instance = new ORMBase<ET>();
            }

            return _instance;
        }

        public DataTable SelectAll()
        {
            string sorgu = "select * from " + typeof(ET).Name + "_Rapor";

            return Getir(sorgu);

        }

        public DataTable SelectAdiAll()
        {
            string sorgu = "select * from " + typeof(ET).Name;

            return Getir(sorgu);
        }

        public DataTable Select(string kolonismi,string deger)
        {
            string sorgu = "";
            PropertyInfo[] props = typeof(ET).GetProperties();

            foreach (PropertyInfo pi in props)
            {
              string tip =pi.PropertyType.Name;

              if (pi.Name == kolonismi)
              {

                  if (tip == "String")
                  {
                      sorgu = "select * from " + typeof(ET).Name + " where " + kolonismi + "='" + deger + "'";
                      break;
                  }
                  else
                  {
                      sorgu = "select * from " + typeof(ET).Name + " where " + kolonismi + "=" + deger;
                  }
              }
            }

            return Getir(sorgu);

        }

        public bool Ekle(ET entity)
        {
            string kolonismi = "insert "+typeof(ET).Name+"(";
            string deger = "";
            string pk =AditionTools<ET>.PKGetir();

            SqlCommand cmd = new SqlCommand();

            PropertyInfo[] props = typeof(ET).GetProperties();

            foreach (PropertyInfo pi in props)
            {
                if (pi.Name==pk)
                {
                    continue;
                }
                if (pi.GetValue(entity)!=null)
                {
                      kolonismi += pi.Name+",";
                      deger += "@" + pi.Name+",";
                      cmd.Parameters.AddWithValue(string.Format("@{0}", pi.Name), pi.GetValue(entity));
                }
               }
            string kolonlar = kolonismi.Remove(kolonismi.Length - 1, 1);
            string degerler = deger.Remove(deger.Length - 1, 1);
            string sorgu = kolonlar + ")" + " values(" + degerler + ")";
            cmd.CommandText = sorgu;
            cmd.Connection = Tools.Connection.Baglanti;

            return Execute.ExecuteNonQuery(cmd);
        }

        public bool Guncelle(ET entity, int id)
        {
            string sorgu = "update " + typeof(ET).Name + " set ";

            SqlCommand cmd = new SqlCommand();

            string pk =AditionTools<ET>.PKGetir();

            PropertyInfo[] props=typeof(ET).GetProperties();

            foreach (PropertyInfo pi in props)
	        {
                if (pi.Name==pk || pi.Name.Contains("Tarih")==true)
                {
                    continue;
                }
                if (pi.GetValue(entity)!=null)
                {
                    sorgu += pi.Name + "=" + string.Format("@{0}", pi.Name) + ",";
                    cmd.Parameters.AddWithValue(string.Format("@{0}", pi.Name), pi.GetValue(entity));
                }
                 
	        }
            string upsorgu = sorgu.Remove(sorgu.Length - 1, 1);

            upsorgu += " where " + pk + "=" + id;

            cmd.CommandText = upsorgu;
            cmd.Connection=Connection.Baglanti;

            return Execute.ExecuteNonQuery(cmd);

        }

        public bool Sil(int id)
        {
            string pk=AditionTools<ET>.PKGetir();
            string sorgu = "delete from " + typeof(ET).Name + " where " + pk + "=" + id;
            SqlCommand cmd = new SqlCommand(sorgu, Connection.Baglanti);

            return Execute.ExecuteNonQuery(cmd);
        }


        private DataTable Getir(string sorgu)
        {
            SqlDataAdapter adp = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand(sorgu, Tools.Connection.Baglanti);
            adp.SelectCommand = cmd;

            DataTable dt = new DataTable();
            adp.Fill(dt);

            return dt;
        }


        public DataTable SelectRapor()
        {
            SqlDataAdapter adp = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand("select * from " +typeof(ET).Name+"_Raporu", Tools.Connection.Baglanti);

            adp.SelectCommand = cmd;

            DataTable dt = new DataTable();
            adp.Fill(dt);

            return dt;
        }
    }
}
