using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Travel_Trip_Web_Sitesi.Models.Siniflar;
namespace Travel_Trip_Web_Sitesi.Controllers
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
        public ActionResult YeniBlog()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniBlog(Blog p)
        {
            c.Blogs.Add(p);
            c.SaveChanges(); //değişiklikleri kaydet
            return RedirectToAction("Index");
        }
        public ActionResult BlogSil(int id)
        {
            var b = c.Blogs.Find(id);//id den gelen değeri bul
            c.Blogs.Remove(b);//b den gelen değeri sil
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult BlogGetir(int id)
        {
            var bl = c.Blogs.Find(id);//id den gelen değeri bul
            return View("BlogGetir", bl);//geriye blogGetir sayfasını döndür - bl den gelen değerleride bu syafayla birlikte getir.
        }
        public ActionResult BlogGuncelle(Blog b)
        {
            var blg = c.Blogs.Find(b.ID);
            blg.Aciklama = b.Aciklama;
            blg.Baslik = b.Baslik;
            blg.BlogImage = b.BlogImage;
            blg.Tarih = b.Tarih;
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
            var b = c.Yorumlars.Find(id);//id den gelen değeri bul
            c.Yorumlars.Remove(b);//b den gelen değeri sil
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
            var yrm = c.Yorumlars.Find(y.ID);
            yrm.KullaniciAdi = y.KullaniciAdi;
            yrm.Mail = y.Mail;
            yrm.Yorum = y.Yorum;
           c.SaveChanges();
            return RedirectToAction("YorumListesi");
        }

    }
}