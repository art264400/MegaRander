using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5Gilich
{
    class Program
    {
        static void Main(string[] args)
        {
            
            for (double nalog = 0.05; nalog < 0.31; nalog += 0.01)
            {
                double Rent = 1.8;
                double Capital = 100000;
                double newCapital = 0;
                double pribil = 0;
                double PostPribil = 0;
                double PostupleniaBudget = 0;
                for (int i = 0; i < 30; i++)
                {
                    newCapital = Capital * Rent;
                    pribil = newCapital - Capital;
                    PostupleniaBudget += pribil * nalog;
                    PostPribil = pribil * (1.0 - nalog);
                    Capital = Capital + PostPribil;
                }

                Console.WriteLine(PostupleniaBudget+" налог="+ nalog);
            }


            //for (double nalog = 0.05; nalog < 0.31; nalog += 0.01)
            //{
            //    double Rent = 1.6;
            //    double Capital = 100000;
            //    double NewCapital = 0;
            //    double pribil;
            //    double PostNalogPribil;
            //    double PostupleniaBudget = 0;
            //    for (int i = 0; i < 30; i++)
            //    {
            //        NewCapital = Capital * Rent;
            //        pribil = NewCapital - Capital;
            //        PostNalogPribil = (1.0 - nalog) * pribil;
            //        PostupleniaBudget += pribil - PostNalogPribil;
            //        Capital += PostNalogPribil;
            //    }

            //    Console.WriteLine(PostupleniaBudget + " Налог=" + nalog + " Капитал " + Capital);

            //}








            //double OldCapital;
            //double NewCapital;
            //double PribilPostNalog;
            //double PostupleniaBudget;
            //var nalog = 0.05;
            //while (nalog <= 0.31)
            //{

            //    NewCapital = 100000;
            //    PribilPostNalog = 0;
            //    PostupleniaBudget = 0;
            //    for (int i = 0; i < 30; i++)
            //    {

            //        NewCapital = NewCapital * 1.2;
            //        PostupleniaBudget = NewCapital * nalog;
            //        NewCapital = (NewCapital - PostupleniaBudget);

            //    }
            //    Console.WriteLine(PostupleniaBudget + " Налог=" + nalog);
            //    nalog += 0.05;
            //}




            Console.ReadKey();
        }
    }
}
