using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            LoadNHibernate();
        }
        public static void LoadNHibernate()
        {
            var repository=new HeroRepository();
            var hero = new Hero()
            {
                HP = 10,
                MP = 2,
                Name = "JONE DOE",
                Profession = "Teacher"
            };
            repository.Add(hero);


            //var cfg = new Configuration();
            //cfg.Configure();
            //cfg.AddAssembly(typeof(Hero).Assembly);
            //new SchemaExport(cfg).Execute(true, true, false);

        }
    }
}
