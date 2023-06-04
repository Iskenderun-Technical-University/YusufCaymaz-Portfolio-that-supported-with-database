using Portfolio_With_Database.Models.Siniflar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Portfolio_With_Database.Controllers
{
    public class MainPageController : Controller
    {
        Context c = new Context();
        // GET: MainPage
        public ActionResult Index()
        {
            var deger = c.AnaSayfas.ToList();

            return View(deger);
        }
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