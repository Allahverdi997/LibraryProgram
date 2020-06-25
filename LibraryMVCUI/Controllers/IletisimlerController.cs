using BusinessLogicalLayer;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LibraryMVCUI.Controllers
{
    public class IletisimlerController : Controller
    {
        //
        // GET: /Iletisimler/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Ekle()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Ekle(Iletisimler il)
        {
            Operations<Iletisimler>.Ekle(il);
            return View();
        }

    }
}
