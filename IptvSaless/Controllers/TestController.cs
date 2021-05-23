using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IptvSaless.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            return View();
        }
        [Authorize]
        public ActionResult identity() {
            return RedirectToAction("index","home","default");
        }
    }
}