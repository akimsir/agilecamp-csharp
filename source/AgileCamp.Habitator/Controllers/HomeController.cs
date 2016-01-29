using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;
using System.Web.Mvc;


namespace AgileCamp.Habitator.Controllers
{
    
    public class HomeController : Controller
    {
        
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Habbit()
        {
            ViewBag.Message = "Управление привычками";

            Session["habbits"] = Session["habbits"] as List<string> ?? new List<string>();

            if (this.Request.HttpMethod == "POST")
            {


                (Session["habbits"] as List<string>).Add(Request.Params.Get("habbitName"));
            }

            ViewBag.habbits = Session["habbits"];

            return View();
        }

        private int _a;
        public int a
        {
            get { return _a + 1; }
            set { _a = value - 1; }
        }


        public string SomeMethod(string name1, string c1, string c2, string name2, int a = 1, int bb3 = 999)
        {
            var baseString = GetBaseString(a, bb3);

            var g8 = baseString + name2 + c1 + name2;
            var g6 = baseString + name2 + c1;

            return name1 + c1 + c2 + g8 + g6;
        }

        public string GetBaseString(int a, int bb3)
        {
            const int a16 = 15;
            const int b = 15;
            const int c = 15;

            return (a16 * (b - c) + a - bb3).ToString();
        }


    }
}