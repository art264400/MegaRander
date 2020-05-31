using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Csv;

namespace csvCaseIn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var csv = System.IO.File.ReadAllText("C:\\Users\\Artur\\Desktop\\case\\PdM_machines.csv");
            var list = new List<Machine>();
            foreach (var line in CsvReader.ReadFromText(csv))
            {        
                var machineID = line["machineID"];
                var model = line["model"];
                var age = line["age"];
                list.Add(new Machine()
                {
                     machineId = Convert.ToInt16(line["machineID"]),
                     model = line["model"],
                     age = Convert.ToInt16(line["age"])
            });
            }
            //var newlist1 = from machine in list
            //              group machine by machine.model into g
            //              select new { model = g.Key, Sum=g.Min() };
            //foreach (var group in phoneGroups2)
            //    Console.WriteLine($"{group.Name} : {group.Count}");
            //SELECT age, MIN(salary) as min FROM workers GROUP BY age
            var model1 = list.Count(m => m.model == "model1");
            var sumAgeModel1= list.Where(m=>m.model== "model1").Sum(m=>m.age);
            var model2 = list.Count(m => m.model == "model2");
            var sumAgeModel2= list.Where(m => m.model == "model2").Sum(m => m.age);
            var model3 = list.Count(m => m.model == "model3");
            var sumAgeModel3 = list.Where(m => m.model =="model3").Sum(m => m.age);
            var model4 = list.Count(m => m.model == "model4");
            var sumAgeModel4 = list.Where(m => m.model == "model4").Sum(m => m.age);
            var avg1 =  sumAgeModel1/model1;
            var avg2 =  sumAgeModel2/model2;
            var avg3 =  sumAgeModel3/ model3;
            var avg4 =  sumAgeModel4/ model4;
            //list.GroupBy(m => m.model).AsEnumerable().Sum(m => m.);
        }
    }
}
