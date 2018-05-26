using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NVC_Food_APP.Controllers
{
    public class JedzenieController : Controller
    {
        // GET: Jedzenie
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Lista(string nazwaKategorii)
        {
            return View();
        }

        public ActionResult Szczeguly(string id)
        {
            return View();
        }
    }
}