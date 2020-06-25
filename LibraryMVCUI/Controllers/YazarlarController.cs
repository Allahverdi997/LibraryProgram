using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessLogicalLayer;
using BusinessLogicalLayer.Extensions;
using Entities.Models;
using System.Drawing;
using System.IO;
using System.Reflection;

namespace LibraryMVCUI.Controllers
{
    public class YazarlarController : Controller
    {
        //
        // GET: /Yazarlar/

        public ActionResult Index()
        {
            DataTable dti = Operations<Iletisimler>.SelectAll();
            List<Iletisimler> il = dti.ToList<Iletisimler>();
            ViewBag.Iletisim = il;

            DataTable dt = Operations<Yazarlar>.SelectAll();
            List<Yazarlar> y = dt.ToList<Yazarlar>();

            return View(y);
        }

        public ActionResult Ekle()
        {
            DataTable dti = Operations<Iletisimler>.SelectAll();
            List<Iletisimler> il = dti.ToList<Iletisimler>();

            return View(il);
        }

        [HttpPost]
        public ActionResult Ekle(Yazarlar y, HttpPostedFileBase FileUp)
        {
            string yol = "";
            if (FileUp != null)
            {
                Image img = Image.FromStream(FileUp.InputStream);

                Bitmap bmp = new Bitmap(img, 350, 210);

                yol = "/Content/YaziciResim/" + Guid.NewGuid() + Path.GetExtension(FileUp.FileName);

                bmp.Save(Server.MapPath(yol));
            }

            Yazarlar ya = new Yazarlar();
            ya.YazarAdi = y.YazarAdi;
            ya.YazarSoyAdi = y.YazarSoyAdi;
            ya.Haqqinda = y.Haqqinda;
            ya.IletisimID = y.IletisimID;
            ya.Resim = yol;

            bool sonuc=Operations<Yazarlar>.Ekle(ya);

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
            Yazarlar y = new Yazarlar();
            DataTable dt = Operations<Yazarlar>.Select("Id", id.ToString());

            DataTable dti = Operations<Iletisimler>.SelectAll();
            List<Iletisimler> il = dti.ToList<Iletisimler>();
            ViewBag.Iletisim = il;

            PropertyInfo[] props = typeof(Yazarlar).GetProperties();
            foreach (DataRow dr in dt.Rows)
            {
                foreach (PropertyInfo pi in props)
                {
                    object value = dr[pi.Name];
                    if (value != DBNull.Value)
                    {
                        pi.SetValue(y, value);
                    }

                }
            }

            return View(y);
        }

        [HttpPost]
        public ActionResult Duzenle(Yazarlar y, HttpPostedFileBase Resim)
        {
            string yol = "";
            if (Resim != null)
            {
                Image img = Image.FromStream(Resim.InputStream);

                Bitmap bmp = new Bitmap(img, 350, 210);

                yol = "/Content/YaziciResim/" + Guid.NewGuid() + Path.GetExtension(Resim.FileName);

                bmp.Save(Server.MapPath(yol));
            }

            Yazarlar ya = new Yazarlar();

            DataTable dt = Operations<Yazarlar>.Select("Id", y.Id.ToString());
            Operations<Yazarlar>.DtToET(dt, ya);

            PropertyInfo[] propes = typeof(Yazarlar).GetProperties();

            foreach (PropertyInfo pi in propes)
            {
                object a = pi.GetValue(y);
                if (a != null || Convert.ToInt32(a) != 0)
                {
                    pi.SetValue(ya, pi.GetValue(y));
                }
            }

            ya.Resim = yol;

            bool sonuc=Operations<Yazarlar>.Guncelle(ya, y.Id);
            if (sonuc)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }

        public string  Sil(int id)
        {
            Operations<Yazarlar>.Sil(id);

            DataTable dt = Operations<Yazarlar>.Select("Id", id.ToString());

            string ad = "";
            foreach (DataRow dr in dt.Rows)
            {
                ad = dr["YazarAdi"].ToString();
            }
            return ad;
        }
    }
}
