using Portfolio_With_Database.Models.Siniflar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Portfolio_With_Database.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        Context c = new Context();
        public ActionResult Index()
        {
            var deger = c.AnaSayfas.ToList();
            return View(deger);
        }
        public ActionResult AnaSayfaGetir(int Id)
        {
            var ag = c.AnaSayfas.Find(Id);
            return View("AnaSayfaGetir", ag);
        }

        public ActionResult AnaSayfaGuncelle(AnaSayfa x)
        {
            var ag = c.AnaSayfas.Find(x.Id);
            ag.Baslik = x.Baslik;
            ag.Aciklama = x.Aciklama;
            ag.Iletisim = x.Iletisim;
            c.SaveChanges();
            return RedirectToAction("Index");

        }
        [HttpGet]
        public ActionResult YeniIkon()
        {
            return View();

        }
        [HttpPost]
        public ActionResult YeniIkon(AnaSayfa p)
        {
            c.AnaSayfas.Add(p);
            c.SaveChanges();
            return RedirectToAction("Index");

        }
        public ActionResult YaziSil(int Id)
        {
            var sil = c.AnaSayfas.Find(Id);
            c.AnaSayfas.Remove(sil);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}