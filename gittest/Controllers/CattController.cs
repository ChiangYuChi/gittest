using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace gittest.Controllers
{
    public class CattController : Controller
    {
        // GET: Catt
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Intro()
        {
            var i = 0;
            return View();
        }
    }
}