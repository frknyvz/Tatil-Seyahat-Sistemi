using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelToLearn.Models.Siniflar;

namespace TravelToLearn.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        Context c = new Context();
        SehirYorum by = new SehirYorum();
        public ActionResult Index()
        { 
           by.Deger1 = c.Blogs.ToList();
           by.Deger3 = c.Blogs.OrderByDescending(x => x.ID).Take(4).ToList();
           return View(by);
        }
        [HttpGet]
        public ActionResult Ara(string ara)
        {
            return View("Ara", c.Blogs.Where(x => x.Baslik.Contains(ara) || 
            ara == null).ToList());
        }
        public ActionResult SehirDetay(int id)
        {
            //var blogbul = c.Blogs.Where(x => x.ID == id).ToList();
            by.Deger1 = c.Blogs.Where(x => x.ID == id).ToList();
            by.Deger2 = c.Yorumlars.Where(x => x.Blogid == id).ToList();
            return View(by);
        }

        [HttpGet]
        public PartialViewResult YorumYap(int id)
        {
            ViewBag.deger = id;
            return PartialView();
        }

        [HttpPost]
        public PartialViewResult YorumYap(Yorumlar s)
        {
            c.Yorumlars.Add(s);
            c.SaveChanges();
            return PartialView();
        }
    }
}