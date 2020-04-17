using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;

namespace ConsoleApp1
{
    class HeroRepository
    {
        public void Add(Hero hero)
        {
            using (ISession session=HibernateHelper.OpenSession())
            {
                using (ITransaction transaction=session.BeginTransaction())
                {
                    session.Save(hero);
                    transaction.Commit();   
                }
            }
        }
    }
}
