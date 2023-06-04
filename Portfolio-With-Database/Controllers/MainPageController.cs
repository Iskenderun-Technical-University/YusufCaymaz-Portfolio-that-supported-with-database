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
        
    }
}