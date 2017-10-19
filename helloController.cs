using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace xiangmu1.Controllers
{
    public class helloController : Controller
    {
        // GET: hello
        public ActionResult Index()
        {

            return View();
        }
        public ActionResult hello()
        {
            ViewBag.message = "hello world";
            return View();
        }
        public ActionResult hello2()
        {
            ViewData["MSG"] = "hello world";
            return View();
        }
    }
}