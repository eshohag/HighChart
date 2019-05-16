using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HighChart.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetData()
        {
            int male = 200;
            int female = 20;
            int other = 5;
            Ratio obj = new Ratio();
            obj.Male = male;
            obj.Female = female;
            obj.Other = other;
            obj.Other1 = 10;
            obj.Other2 = 33;


            return Json(obj, JsonRequestBehavior.AllowGet);
        }
        public class Ratio
        {
            public int Male { get; set; }
            public int Female { get; set; }
            public int Other { get; set; }
            public int Other1 { get; set; }
            public int Other2 { get; set; }
        }
    }
}