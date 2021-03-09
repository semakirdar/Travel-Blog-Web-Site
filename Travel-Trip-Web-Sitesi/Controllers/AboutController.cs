using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Travel_Trip_Web_Sitesi.Models.Siniflar;

namespace Travel_Trip_Web_Sitesi.Controllers
{
    public class AboutController : Controller
    {
        // GET: About
        Context c = new Context();//context üzerinden nesne türeticez.
        public ActionResult Index()
        {
            var degerler = c.Hakkimizdas.ToList();
            return View(degerler);
        }
    }
}