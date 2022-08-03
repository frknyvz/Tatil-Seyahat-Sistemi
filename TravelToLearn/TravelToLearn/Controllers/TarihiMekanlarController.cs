using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelToLearn.Models.Siniflar;

namespace TravelToLearn.Controllers
{
    public class TarihiMekanlarController : Controller
    {
        // GET: TarihiMekanlar
        Context c = new Context();

        public ActionResult Index()
        {
            var degerler = c.TarihiMekanlars.ToList();
            return View(degerler);
        }
        [HttpGet]
        public ActionResult Ara(string ara)
        {
            return View("Ara", c.TarihiMekanlars .Where(x => x.SehirAdi.Contains(ara) ||
            ara == null).ToList());
        }
    }
}