using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessLogicalLayer;
using BusinessLogicalLayer.Extensions;
using Entities.Models;
using System.Data;

namespace LibraryMVCUI.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            DataTable dt= Operations<Kitablar>.SelectAll();

            List<Kitablar> kitab = dt.ToList<Kitablar>();

            ViewBag.Kullanici = HttpContext.Application["Kullanici"];
            return View(kitab);
        }

        public void Sepet(int id)
        {
            if (Session["AktifSepet"] == null)
            {
                Sepet s = new Sepet();
                SepetEleman se=new SepetEleman();
                Kitablar k = new Kitablar();

                DataTable dt=Operations<Kitablar>.Select("Id", id.ToString());
                k=Operations<Kitablar>.DtToET(dt, k);

                se.Kitab = k;
                se.Adet = 1;

                s.Ekle(se);

                Session["AktifSepet"] = s;
            }
            else
            {
                Sepet s = (Sepet)Session["AktifSepet"];

                Kitablar k = new Kitablar();

                DataTable dt = Operations<Kitablar>.Select("Id", id.ToString());
                k = Operations<Kitablar>.DtToET(dt, k);

                SepetEleman se = new SepetEleman();
                se.Kitab = k;
                se.Adet = 1;

                s.Eleman.Add(se);

                Session["AktifSepet"] = s;
            }
        }

        public void SepettenSil(int id)
        {
            Sepet s = (Sepet)Session["AktifSepet"];

            SepetEleman sep = s.Eleman.FirstOrDefault(x => x.Kitab.Id == id);

            s.Eleman.Remove(sep);
            Session["AktifSepet"] = s;
        }

        public PartialViewResult Kargo()
        {
            DataTable dtk = Operations<Kargolar>.SelectAll();

            List<Kargolar> kargo = dtk.ToList<Kargolar>();

            return PartialView(kargo);
        }

        public PartialViewResult Kategori()
        {
            DataTable dt = Operations<Kategoriler>.SelectAll();

            List<Kategoriler> kategori = dt.ToList<Kategoriler>();

            return PartialView(kategori);
        }

        public PartialViewResult Yazicilar()
        {
            DataTable dt = Operations<Yazarlar>.SelectAll();

            List<Yazarlar> yazar = dt.ToList<Yazarlar>();

            return PartialView(yazar);
        }
    }
}
