using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvc_on_webform.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Site1() {
            Server.Transfer("~/WebForm/Site1/WebForm1.aspx");
            return View();
        }
    }
}