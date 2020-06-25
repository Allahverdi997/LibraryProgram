using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using System.Reflection;
using System.Drawing;
using System.IO;

namespace LibraryMVCUI.Controllers
{
    public class SliderResimController : Controller
    {
        //
        // GET: /SliderResim/

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Ekle(HttpPostedFileBase FileUp)
        {
            if (FileUp!=null)
            {
                System.Drawing.Image img = System.Drawing.Image.FromStream(FileUp.InputStream);

                Bitmap bmp = new Bitmap(img, 1920, 1920);

                string yol = "/Content/SliderResim/" + Guid.NewGuid() + Path.GetExtension(FileUp.FileName);

                bmp.Save(Server.MapPath(yol));
            }
            return View();
        }
    }
}
