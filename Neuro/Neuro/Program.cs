using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neuro
{
  
    class Program
    {
     

        public static void Init(int[] input,Random rnd)
        {
            input[10] = 0;
            int sum = 0;
            for (int i = 0; i < 10; i++)
            {
                input[i] = rnd.Next(2);
                sum = sum+input[i];
            }

            if (sum > 5)
            {
                input[10] = 1;
            }
        }

        public static double Sigmoid(double x)
        {
           
            return 1 / (1 + Math.Exp(-x));
        }
        static void Main(string[] args)
        {
            double delta=0;
            Random rnd = new Random(6);
            double Error=0;
            double weights_delta=0;
            double TMP = 0.8;
            double sum = 0;
            int[] input = new int[11];
            Init(input, rnd);
            double[] weights = new []{ -0.4, 0.39, -0.49, 0.12, 0.1, 0.33, -0.31, 0.2, 0.3, 0.5 };
            for (int k= 0; k < 20000; k++)
            {
              
                 sum = 0;
                for (int i = 0; i < 10; i++)
                {
                    sum = sum + (weights[i] * input[i]);
                }

                //delta = input[10] - Sigmoid(sum);
                Error=(input[10]-Sigmoid(sum))* Sigmoid(sum)*(1- Sigmoid(sum));//Ошибка для выходного элемента
                //weights_delta = Error * (Sigmoid(sum) * (1 - Sigmoid(sum)));
                //Error = 0.5 * weights_delta * weights_delta;
                
                for (int i = 0; i < 10; i++)
                {
                    weights[i] = weights[i] +(Error * TMP * input[i]);
                }




                if (k % 2000 == 0)
                {
                    for (int i = 0; i < 10; i++)
                    {
                        Console.Write(input[i]+" ");
                    }
                    Console.Write( Sigmoid(sum));
                    Console.WriteLine();
                    Init(input, rnd);     
                }
            }
            string writePath = @"C:\neuron\weights.txt";
            using (StreamWriter sw = new StreamWriter(writePath))
            {
                for (int i = 0; i < 10; i++)
                {
                    sw.WriteLine(weights[i]);
                }
            }
            
            for (int i = 0; i < 10; i++)
            {
                input[i] = rnd.Next(2);
            }
            sum = 0;
            for (int i = 0; i < 10; i++)
            {
                sum = sum + (weights[i] * input[i]);
            }
            
            
            Console.WriteLine("Ошибка=" + String.Format("{0:0.00000}",Error));
            for (int i = 0; i < 10; i++)
            {
               Console.Write(input[i]+" ");
            }
            Console.Write(String.Format("{0:0.00}", Sigmoid(sum)));
            Console.ReadKey();
        }
    }
}
