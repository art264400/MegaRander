using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.WebPages;
using case_in.Models;
using Csv;
using Excel = Microsoft.Office.Interop.Excel;

namespace case_in.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var csv = System.IO.File.ReadAllText("C:\\Users\\Artur\\Desktop\\case\\PdM_errors.csv");
            var list = new ArrayList();
            foreach (var line in CsvReader.ReadFromText(csv))
            {
                var datetime = line["datetime"];
                var machineID = line["machineID"];
                var errorID = line["errorID"];
                list.Add(new Error()
                {
                    DateTime = datetime.AsDateTime(),
                    MachineId = Convert.ToInt32(machineID),
                    ErrorId = errorID
                });
            }
           
          
            return View(list.ToArray());
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
    }
}