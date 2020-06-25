using DataAccessLayer.AdoNet;
using DataAccessLayer.Tools;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Entities.Models;
using DataAccessLayer;
using System.Data;

namespace BusinessLogicalLayer
{
    public class User
    {
        public static bool Yoxla(string ad, string parol)
        {
            string[] str = UserYoxlaTool(ad, parol);

            if (str[0]!=null)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        public static string[] IdRolGetir(string ad, string parol)
        {
            string[] str = UserYoxlaTool(ad, parol);

                return str;
        }


        private static string[] UserYoxlaTool(string ad, string parol)
        {
            ORM<IsciSistemMelumat> orm = new ORM<IsciSistemMelumat>(ORMBase<IsciSistemMelumat>.InstanceGetir());
            DataTable dt = orm.Select("Username", ad);

            string[] str = new string[3];
               
            foreach (DataRow dr in dt.Rows)
                {
                    if (dr["Password"].ToString() == parol)
                    {
                        str[0] = dr["IsciID"].ToString();
                        str[1] = dr["Rol"].ToString();
                    }
                    
                }
            return str;

            
        }

        public static string AdGetir(string id)
        {
            string ad = "";

            ORM<Iskiler> orm = new ORM<Iskiler>(ORMBase<Iskiler>.InstanceGetir());
            DataTable dt = orm.Select("IsciId", id);

            foreach (DataRow dr in dt.Rows)
            {
                ad = dr["IsciAdi"].ToString();
            }
            return ad;
        }
    }
}
