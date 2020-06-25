using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicalLayer.Extensions
{
    public static class ExtensionToList
    {
        public static List<ET> ToList<ET>(this DataTable dt) where ET : class,new()
        {
            PropertyInfo[] props = typeof(ET).GetProperties();

            List<ET> list=new List<ET>();
            
            foreach (DataRow dr in dt.Rows)
            {
                ET et=new ET();
                
                foreach (PropertyInfo pi in props)
                {
                    if (dr[pi.Name]!=null)
                    {
                        
                    }
                    object value = dr[pi.Name];
                    if (value!=DBNull.Value)
                    {
                        pi.SetValue(et, value);
                    }
                }
                list.Add(et);
            }
            return list;

            
        }
    }
}
