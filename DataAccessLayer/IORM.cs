using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public interface IORM<ET> where ET:class
    {
        DataTable SelectAll();
        DataTable SelectAdiAll();
        DataTable Select(string kolonismi, string deger);
        bool Ekle(ET entity);
        bool Guncelle(ET entity,int id);
        bool Sil(int id);
        DataTable SelectRapor();
    }
}
