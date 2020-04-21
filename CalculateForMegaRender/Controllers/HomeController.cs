using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CalculateForMegaRender.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Multiplication()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Multiplication(int[,] x,int[,] y)
        {

            return View();
        }
    }
}