using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Entities.Models;
namespace LibraryMVCUI
{
    public class Sepet
    {
        private List<SepetEleman> eleman=new List<SepetEleman>();

        public List<SepetEleman> Eleman
        {
            get { return eleman; }
            set { eleman = value; }
        }

        public int Say
        {
            get 
            {
                int a=0;
                foreach (SepetEleman se in Eleman)
                {
                    a++;
                }
                return a;
            }
        }
        
        public void Ekle(SepetEleman eleman)
        {
            if (Eleman.FirstOrDefault(x=>x.Kitab.Id==eleman.Kitab.Id)!=null)
            {
                eleman.Adet++;
            }
            else
            {
                Eleman.Add(eleman);
            }
        }

        private decimal ToplamQiymet;

        public decimal Toplamqiymet
        {
            get 
            {
                decimal fiyat = 0;
                foreach (SepetEleman e in Eleman)
                {
                    fiyat+=e.Qiymet; 
                }
                return fiyat;
            }
        }
        
        
    }

    public class SepetEleman
    {
        public Kitablar Kitab { get; set; }
        public int Adet { get; set; }
        private decimal qiymet;

        public decimal Qiymet
        {
            get
            {
                return qiymet = Kitab.Fiyati * Adet;
            }
        }
    }
}