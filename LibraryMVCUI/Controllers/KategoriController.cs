using BusinessLogicalLayer;
using BusinessLogicalLayer.Extensions;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Drawing;
using System.IO;
using System.Reflection;

namespace LibraryMVCUI.Controllers
{
    public class KategoriController : Controller
    {
        //
        // GET: /Kategori/

        public ActionResult Index()
        {
            DataTable dt = Operations<Kategoriler>.SelectAll();
            List<Kategoriler> k = dt.ToList<Kategoriler>();

            return View(k);
        }

        public ActionResult Ekle()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Ekle(Kategoriler ka, HttpPostedFileBase FileUp)
        {
            string yol = "";
            if (FileUp!=null)
            {
                Image img = Image.FromStream(FileUp.InputStream);

                Bitmap bmp = new Bitmap(img, 350, 210);

                yol = "/Content/KategoriResim/" + Guid.NewGuid() + Path.GetExtension(FileUp.FileName);

                bmp.Save(Server.MapPath(yol));
            }
            Kategoriler k = new Kategoriler();
            k.KategoriAdi = ka.KategoriAdi;
            k.KategoriAciklamasi = ka.KategoriAciklamasi;
            k.KategoriResim = yol;

            bool sonuc=Operations<Kategoriler>.Ekle(k);

            if (sonuc)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
            
        }

        public ActionResult Duzenle(int id)
        {
            Kategoriler k = new Kategoriler();
            DataTable dt = Operations<Kategoriler>.Select("Id", id.ToString());
            PropertyInfo[] props = typeof(Kategoriler).GetProperties();
            foreach (DataRow dr in dt.Rows)
            {
                foreach (PropertyInfo pi in props)
                {
                    object value = dr[pi.Name];
                    if (value != DBNull.Value)
                    {
                        pi.SetValue(k, value);
                    }

                }
            }


            return View(k);
        }

        [HttpPost]
        public ActionResult Duzenle(Kategoriler ka,HttpPostedFileBase Resim)
        {
            string yol = "";
            if (Resim != null)
            {
                Image img = Image.FromStream(Resim.InputStream);

                Bitmap bmp = new Bitmap(img, 350, 210);

                yol = "/Content/KategoriResim/" + Guid.NewGuid() + Path.GetExtension(Resim.FileName);

                bmp.Save(Server.MapPath(yol));
            }

            Kategoriler k = new Kategoriler();

            DataTable dt = Operations<Kategoriler>.Select("Id", ka.Id.ToString());
            Operations<Kategoriler>.DtToET(dt, k);

            PropertyInfo[] propes = typeof(Kategoriler).GetProperties();

            foreach (PropertyInfo pi in propes)
            {
                object a = pi.GetValue(k);
                if (a != null || Convert.ToInt32(a) != 0)
                {
                    pi.SetValue(k, pi.GetValue(ka));
                }
            }

            k.KategoriResim = yol;

            bool sonuc=Operations<Kategoriler>.Guncelle(k, ka.Id);

            if (sonuc)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
            
        }

        public string Sil(int id)
        {
            Operations<Kategoriler>.Sil(id);

            DataTable dt = Operations<Kategoriler>.Select("Id", id.ToString());

            string ad = "";
            foreach (DataRow dr in dt.Rows)
            {
                ad = dr["KategoriAdi"].ToString();
            }
            return ad;
        }

    }
}
