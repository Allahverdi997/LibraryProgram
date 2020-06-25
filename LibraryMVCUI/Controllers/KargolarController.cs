using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessLogicalLayer;
using BusinessLogicalLayer.Extensions;
using Entities.Models;

namespace LibraryMVCUI.Controllers
{
    public class KargolarController : Controller
    {
        //
        // GET: /Kargolar/

        public ActionResult Index()
        {
            DataTable dt = Operations<Kargolar>.SelectAll();
            List<Kargolar> kargo = dt.ToList<Kargolar>();

            DataTable dti = Operations<Iletisimler>.SelectAll();
            List<Iletisimler> il = dti.ToList<Iletisimler>();

            ViewBag.Iletisim = il;

            return View(kargo);
        }

        public ActionResult Ekle()
        {
            DataTable dti = Operations<Iletisimler>.SelectAll();
            List<Iletisimler> il = dti.ToList<Iletisimler>();

            return View(il);
        }

        [HttpPost]
        public ActionResult Ekle(Kargolar ka)
        {
            Kargolar k = new Kargolar();

            k.KargoAd = ka.KargoAd;
            k.IletisimID = ka.IletisimID;

            bool sonuc=Operations<Kargolar>.Ekle(k);

            if (sonuc==true)
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
            Operations<Kargolar>.Sil(id);

            DataTable dt = Operations<Kargolar>.Select("Id", id.ToString());

            string ad = "";
            foreach (DataRow dr in dt.Rows)
            {
                ad = dr["KargoAd"].ToString();
            }
            return ad;
        }

        public ActionResult Duzenle(int id)
        {
            DataTable dti = Operations<Iletisimler>.SelectAll();
            List<Iletisimler> il = dti.ToList<Iletisimler>();
            ViewBag.Iletisim = il;

            Kargolar k = new Kargolar();

            DataTable dt = Operations<Kargolar>.Select("Id", id.ToString());
            k = Operations<Kargolar>.DtToET(dt, k);

            return View(k);
        }

        [HttpPost]
        public ActionResult Duzenle(Kargolar k)
        {
            
            Kargolar ka = new Kargolar();

            ka.IletisimID = k.IletisimID;
            ka.KargoAd = k.KargoAd;

            Operations<Kargolar>.Guncelle(ka, k.Id);
            return RedirectToAction("Index");
        }
    }
}
