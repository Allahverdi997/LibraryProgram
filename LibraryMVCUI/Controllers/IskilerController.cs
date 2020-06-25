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
    public class IskilerController : Controller
    {
        //
        // GET: /Iskiler/

        public ActionResult Index()
        {
            DataTable dt = Operations<Iskiler>.SelectAll();

            DataTable dti = Operations<Iletisimler>.SelectAll();
            List<Iletisimler> iletisim = dti.ToList<Iletisimler>();

            ViewBag.Iletisim = iletisim;

            List<Iskiler> iskiler = dt.ToList<Iskiler>();
            return View(iskiler);
        }

        public ActionResult Ekle()
        {
            DataTable dti = Operations<Iletisimler>.SelectAll();
            List<Iletisimler> iletisim = dti.ToList<Iletisimler>();
            ViewBag.Iletisim = iletisim;

            return View();
        }

        [HttpPost]
        public ActionResult Ekle(Iskiler i, HttpPostedFileBase FileUp)
        {
            string name = "";
            if (FileUp!=null)
            {
                Image img = Image.FromStream(FileUp.InputStream);

                Bitmap bmp = new Bitmap(img, 300, 300);

                name = "/Content/IsciResim/" + Guid.NewGuid() + Path.GetExtension(FileUp.FileName);

                bmp.Save(Server.MapPath(name));
            }

            Iskiler isk=new Iskiler();

            isk.IsciAdi = i.IsciAdi;
            isk.Soyadi = i.Soyadi;
            isk.Maas = i.Maas;
            isk.IletisimID = i.IletisimID;
            isk.Dogum = i.Dogum;
            isk.IsciResim = name;

            Operations<Iskiler>.Ekle(isk);
            return RedirectToAction("Index");
        }

        public ActionResult Duzenle(int id)
        {
            Iskiler i = new Iskiler();

            DataTable dt=Operations<Iskiler>.Select("IsciId", id.ToString());
            i=Operations<Iskiler>.DtToET(dt, i);
            DataTable dti=Operations<Iletisimler>.SelectAll();

            List<Iletisimler> Iletisim=dti.ToList<Iletisimler>();

            ViewBag.Iletisim = Iletisim;
            return View(i);
        }

        [HttpPost]
        public ActionResult Duzenle(Iskiler i,HttpPostedFileBase FileUp)
        {
            string name = "";
            if (FileUp != null)
            {
                Image img = Image.FromStream(FileUp.InputStream);

                Bitmap bmp = new Bitmap(img, 300, 300);

                name = "/Content/IsciResim/" + Guid.NewGuid() + Path.GetExtension(FileUp.FileName);

                bmp.Save(Server.MapPath(name));
            }

            Iskiler isk = new Iskiler();
            DataTable dt = Operations<Iskiler>.Select("IsciId", i.IsciId.ToString());
            i = Operations<Iskiler>.DtToET(dt, i);

            PropertyInfo[] propes = typeof(Iskiler).GetProperties();

            foreach (PropertyInfo pi in propes)
            {
                object a = pi.GetValue(i);
                if (a != null || Convert.ToInt32(a) != 0)
                {
                    pi.SetValue(isk, pi.GetValue(i));
                }
            }

            isk.IsciResim = name;

            Operations<Iskiler>.Guncelle(isk, i.IsciId);
            return RedirectToAction("Index");
        }

        public string Sil(int id)
        {
            Operations<Iskiler>.Sil(id);

            DataTable dt = Operations<Iskiler>.Select("IsciId", id.ToString());

            string ad = "";
            foreach (DataRow dr in dt.Rows)
            {
                ad = dr["IsciAdi"].ToString();
            }
            return ad;
        }

    }
}
