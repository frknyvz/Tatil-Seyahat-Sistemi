using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelToLearn.Models.Siniflar;

namespace TravelToLearn.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        Context c = new Context();
        [Authorize]
        public ActionResult Index()
        {
            var degerler = c.Blogs.ToList();
            return View(degerler);
        }
        [HttpGet]
        public ActionResult YeniSehir()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniSehir(Blog p)
        {
            c.Blogs.Add(p);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult SehirSil(int id)
        {
            var s = c.Blogs.Find(id);
            c.Blogs.Remove(s);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult SehirGuncelle(int id)
        {
            var se = c.Blogs.Find(id);          
            return View("SehirGuncelle", se);
        }
        public ActionResult SehirUpdate(Blog s)
        {
            var seh = c.Blogs.Find(s.ID);
            seh.Aciklama = s.Aciklama;
            seh.Baslik = s.Baslik;
            seh.BlogImage = s.BlogImage;
            seh.Tarih = s.Tarih;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult YorumListesi()
        {
            var yorumlar = c.Yorumlars.ToList();
            return View(yorumlar);
        }
        public ActionResult YorumSil(int id)
        {
            var s = c.Yorumlars.Find(id);
            c.Yorumlars.Remove(s);
            c.SaveChanges();
            return RedirectToAction("YorumListesi");
        }
        public ActionResult YorumGetir(int id)
        {
            var yr = c.Yorumlars.Find(id);
            return View("YorumGetir", yr);
        }
        public ActionResult YorumGuncelle(Yorumlar y)
        {
            var yo = c.Yorumlars.Find(y.ID);
            yo.KullaniciAdi = y.KullaniciAdi;
            yo.Mail = y.Mail;
            yo.Yorum = y.Yorum;
            c.SaveChanges();
            return RedirectToAction("YorumListesi");
        }
    }
}