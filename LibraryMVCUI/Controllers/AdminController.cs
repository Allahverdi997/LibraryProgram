using BusinessLogicalLayer;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessLogicalLayer.Extensions;

namespace LibraryMVCUI.Controllers
{
    public class AdminController : Controller
    {
        //
        // GET: /Admin/

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

        

    }
}
