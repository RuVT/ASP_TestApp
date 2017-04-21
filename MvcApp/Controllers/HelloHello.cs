using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApp.Controllers
{
    public class TestModel
    {
        public int Number { get; set; }
        public string Name { get; set; }
    }

    public class HelloHelloController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [AcceptVerbs(HttpVerbs.Get)]
        public ActionResult Welcome(TestModel model)
        {
            ViewBag.data = model;
            return View();
        }

        //public ActionResult Index()
        //{
        //    return View();
        //}

    }
}

