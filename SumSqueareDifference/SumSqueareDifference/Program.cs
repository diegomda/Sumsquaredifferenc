using System.Collections.Generic;
using System;
using System.Linq;

namespace SumSqueareDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            double a =0;
            double c = 0;
            double x = 0;
            double s = 0;

            List<double> num1 = new List<double>();
            for (double i = 1; i <= 100; i++)
            {
                a = Math.Pow(i, 2);
                s = a + s;
            }
            for (double e = 1; e <= 100; e++)
            {
                c = c + e;
            }
            x = Math.Pow(c, 2);
            Console.WriteLine(x-s);
            Console.ReadKey();
            }
        }
    }

