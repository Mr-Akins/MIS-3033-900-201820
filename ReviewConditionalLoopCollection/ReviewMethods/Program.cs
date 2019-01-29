using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewMethods
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Hello");

            double val1, val2;
            val1 = 5;
            val2 = 25.283973;

            double sol = Add(val1, val2);
            Console.WriteLine(sol);

            Subtract(56.5, 383.3);

            Console.ReadKey();
        }

        private static void Subtract(double v1, double v2)
        {
            Console.WriteLine($"{(v1 - v2).ToString("N4")}");
        }

        static double Add(double val1, double val2)
        {
            double solution = val1 + val2;
            return solution;
        }
    }
}
