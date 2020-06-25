using DataAccessLayer;
using DataAccessLayer.AdoNet;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Reflection;
using DataAccessLayer.Tools;

namespace BusinessLogicalLayer
{
    public class Operations<ET> where ET : class
    {
        public static DataTable Select(string kolonismi, string deger)
        {
            ORM<ET> orm = new ORM<ET>(ORMBase<ET>.InstanceGetir());
            return orm.Select(kolonismi, deger);
        }

        public static DataTable SelectAll()
        {
            ORM<ET> orm = new ORM<ET>(ORMBase<ET>.InstanceGetir());
            return orm.SelectAll();
        }

        public static bool Ekle(ET entity)
        {
            ORM<ET> orm = new ORM<ET>(ORMBase<ET>.InstanceGetir());
            return orm.Ekle(entity);
        }

        public static bool Sil(int id)
        {
            ORM<ET> orm = new ORM<ET>(ORMBase<ET>.InstanceGetir());
            return orm.Sil(id);
        }
        public static bool Guncelle(ET entity, int id)
        {
            ORM<ET> orm = new ORM<ET>(ORMBase<ET>.InstanceGetir());
            return orm.Guncelle(entity, id);
        }

        public static int EkleneniYoxla(string kolonismi, string deger)
        {
            ORM<ET> orm = new ORM<ET>(ORMBase<ET>.InstanceGetir());
            DataTable dt = orm.Select(kolonismi, deger);

            int sayac = 0;
            foreach (DataRow dr in dt.Rows)
            {
                sayac++;
            }
            return sayac;
        }
        public static ET EntityDoldur(ET entity, params object[] obj)
        {
            PropertyInfo[] props = typeof(ET).GetProperties();

            int i = 0;

            foreach (PropertyInfo pi in props)
            {
                if (i < obj.Length)
                {
                    if (pi.Name == AditionTools<ET>.PKGetir())
                    {
                        continue;
                    }

                    string tip = pi.PropertyType.Name;
                    switch (tip)
                    {
                        case "String": pi.SetValue(entity, obj[i].ToString());
                            break;
                        case "Int32": pi.SetValue(entity, Convert.ToInt32(obj[i]));
                            break;
                        case "Decimal": pi.SetValue(entity, Convert.ToDecimal(obj[i]));
                            break;
                        case "Int16": pi.SetValue(entity, Convert.ToInt16(obj[i]));
                            break;
                        case "Double": pi.SetValue(entity, Convert.ToDouble(obj[i]));
                            break;
                        case "DateTime": pi.SetValue(entity, Convert.ToDateTime(obj[i]));
                            break;
                        case "Boolean": pi.SetValue(entity, Convert.ToBoolean(obj[i]));
                            break;
                    }
                    i++;
                }

            }
            return entity;
        }

        public static ET DtToET(DataTable dt, ET entity)
        {
            PropertyInfo[] props = typeof(ET).GetProperties();

            foreach (DataRow dr in dt.Rows)
            {
                foreach (PropertyInfo pi in props)
                {
                    object value = dr[pi.Name];
                    if (value != DBNull.Value)
                    {
                        pi.SetValue(entity, value);
                    }

                }
            }
            return entity;
        }

        public static DataTable SelectRapor()
        {
            ORM<ET> orm = new ORM<ET>(ORMBase<ET>.InstanceGetir());
            return orm.SelectRapor();
        }
    }
}

