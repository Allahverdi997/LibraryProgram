using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Tools;
using System.Data;

namespace DataAccessLayer
{
    public class ORM<ET> where ET:class
    {
        private IORM<ET> orm;

        public ORM(IORM<ET> _orm)
        {
            orm = _orm;
        }

        public  DataTable SelectAll()
        {
            return orm.SelectAll();
        }

        public DataTable Select(string kolonismi,string deger)
        {
            return orm.Select(kolonismi,deger);
        }

        public bool Ekle(ET entity)
        {
            return orm.Ekle(entity);
        }

        public bool Guncelle(ET entity, int id)
        {
            return orm.Guncelle(entity, id);
        }

        public bool Sil(int id)
        {
            return orm.Sil(id);
        }

        public DataTable SelectRapor()
        {
            return orm.SelectRapor();
        }

    }
}
