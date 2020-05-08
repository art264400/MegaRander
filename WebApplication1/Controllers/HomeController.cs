using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : ApiController
    {
        public ActionResult Index()
        {
           

            return View();
        }
    }
}
