using BusinessLogicalLayer;
using BusinessLogicalLayer.Extensions;
using Entities.Models;
using System;
using System.IO;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using System.Reflection;

namespace LibraryMVCUI.Controllers
{
    public class KitabController : Controller
    {
        //
        // GET: /Kitab/

        public ActionResult Index()
        {
            DataTable dt = Operations<Kitablar>.SelectAll();
            DataTable dtf = Operations<FerdiTedarikci>.SelectAll();
            DataTable dts = Operations<SirketTedarikci>.SelectAll();
            DataTable dtk = Operations<Kategoriler>.SelectAll();
            DataTable dty = Operations<Yazarlar>.SelectAll();

            List<Kitablar> kitablar = dt.ToList<Kitablar>();
            List<FerdiTedarikci> ferdi = dtf.ToList<FerdiTedarikci>();
            List<SirketTedarikci> sirket = dts.ToList<SirketTedarikci>();
            List<Kategoriler> kategoriler = dtk.ToList<Kategoriler>();
            List<Yazarlar> yazarlar = dty.ToList<Yazarlar>();


            ViewBag.Ferdi = ferdi;
            ViewBag.Sirket = sirket;
            ViewBag.Kategori = kategoriler;
            ViewBag.Yazar = yazarlar;

            return View(kitablar);
        }

        public ActionResult Ekle()
        {
            DataTable dtk = Operations<Kategoriler>.SelectAll();
            List<Kategoriler> kategoriler = dtk.ToList<Kategoriler>();
            ViewBag.Kategori = kategoriler;


            DataTable dtf = Operations<FerdiTedarikci>.SelectAll();
            DataTable dts = Operations<SirketTedarikci>.SelectAll();

            List<FerdiTedarikci> ferdi = dtf.ToList<FerdiTedarikci>();
            List<SirketTedarikci> sirket = dts.ToList<SirketTedarikci>();
            ViewBag.Ferdi = ferdi;
            ViewBag.Sirket = sirket;



            DataTable dty = Operations<Yazarlar>.SelectAll();
            List<Yazarlar> yazarlar = dty.ToList<Yazarlar>();
            ViewBag.Yazar = yazarlar;
            return View();
        }

        [HttpPost]
        public ActionResult Ekle(Kitablar ki, HttpPostedFileBase FileUp)
        {
            string isim = "";
            if (FileUp != null)
            {
                System.Drawing.Image img = System.Drawing.Image.FromStream(FileUp.InputStream);

                Bitmap bmp = new Bitmap(img, 300, 300);

                isim = "/Content/KitapResim/" + (Guid.NewGuid()).ToString() + Path.GetExtension(FileUp.FileName);
                bmp.Save(Server.MapPath(isim));
            }

            Kitablar k = new Kitablar();
            k.BarkodNo = ki.BarkodNo;
            k.Fiyati = ki.Fiyati;
            k.KategoriID = ki.KategoriID;
            k.TedarikciID = ki.TedarikciID;
            k.KitabAciklamasi = ki.KitabAciklamasi;
            k.KitabAdi = ki.KitabAdi;
            k.KitabResim = isim;
            k.Miktar = ki.Miktar;
            k.VereqSayi = ki.VereqSayi;
            k.YayinEvi = ki.YayinEvi;
            k.YazarID = ki.YazarID;

            Operations<Kitablar>.Ekle(k);
            return RedirectToAction("Index");
        }

        public ActionResult Duzenle(int id)
        {
            DataTable dtk = Operations<Kategoriler>.SelectAll();
            List<Kategoriler> kategoriler = dtk.ToList<Kategoriler>();
            ViewBag.Kategori = kategoriler;


            DataTable dtf = Operations<FerdiTedarikci>.SelectAll();
            DataTable dts = Operations<SirketTedarikci>.SelectAll();

            List<FerdiTedarikci> ferdi = dtf.ToList<FerdiTedarikci>();
            List<SirketTedarikci> sirket = dts.ToList<SirketTedarikci>();
            ViewBag.Ferdi = ferdi;
            ViewBag.Sirket = sirket;



            DataTable dty = Operations<Yazarlar>.SelectAll();
            List<Yazarlar> yazarlar = dty.ToList<Yazarlar>();
            ViewBag.Yazar = yazarlar;

            Kitablar ki = new Kitablar();

            DataTable dt=Operations<Kitablar>.Select("Id",id.ToString());
            PropertyInfo[] props=typeof(Kitablar).GetProperties();
            foreach (DataRow dr in dt.Rows)
	        {
		         foreach (PropertyInfo pi in props)
	             {
                     object value = dr[pi.Name];
                     if (value!=DBNull.Value)
                     {
                         pi.SetValue(ki,value);
                     }
                     
	             }
	        }

             
            return View(ki);
        }

        [HttpPost]
        public ActionResult Duzenle(Kitablar k, HttpPostedFileBase Resim)
        {
            string isim = "";
            if (Resim != null)
            {
                System.Drawing.Image img = System.Drawing.Image.FromStream(Resim.InputStream);

                Bitmap bmp = new Bitmap(img, 300, 300);

                isim = "/Content/KitapResim/" + (Guid.NewGuid()).ToString() + Path.GetExtension(Resim.FileName);
                bmp.Save(Server.MapPath(isim));
            }

            Kitablar ki = new Kitablar();

            DataTable dt = Operations<Kitablar>.Select("Id",k.Id.ToString());
            Operations<Kitablar>.DtToET(dt, ki);

            PropertyInfo[] propes = typeof(Kitablar).GetProperties();

            foreach (PropertyInfo pi in propes)
            {
                object a = pi.GetValue(k);
                if (a != null || Convert.ToInt32(a) != 0)
                {
                    pi.SetValue(ki, pi.GetValue(k));
                }
            }

            ki.KitabResim = isim;

            Operations<Kitablar>.Guncelle(ki, k.Id);
            return RedirectToAction("Index");
        }

        public string Sil(int id)
        {
            Operations<Kitablar>.Sil(id);

            DataTable dt=Operations<Kitablar>.Select("Id",id.ToString());

            string ad="";
            foreach(DataRow dr in dt.Rows)
            {
                ad=dr["KitabAdi"].ToString();
            }
            return ad;
        }


        public ActionResult KitabDetay(int id)
        {
            DataTable dt = Operations<Kitablar>.Select("Id", id.ToString());
            Kitablar k = new Kitablar();

            k = Operations<Kitablar>.DtToET(dt, k);

            return View(k);
        }

    }
}
