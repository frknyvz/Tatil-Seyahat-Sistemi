using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelToLearn.Models.Siniflar;

namespace TravelToLearn.Controllers
{
    public class GezilecekYerlerController : Controller
    {
        // GET: GezilecekYerler
        Context c = new Context();

        public ActionResult Index()
        {
            var degerler = c.GezilecekYerlers.ToList();
            return View(degerler);
        }
        [HttpGet]
        public ActionResult Ara(string ara)
        {
            return View("Ara", c.GezilecekYerlers.Where(x => x.SehirAdi.Contains(ara) ||
            ara == null).ToList());
        }
    }
}