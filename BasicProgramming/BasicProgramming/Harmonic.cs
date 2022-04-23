using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgramming
{
    internal class Harmonic
    {
        public void HarmonicSeries()
        {
            double d = 0;
            Console.WriteLine("Enter the values of n");
            double n = Convert.ToDouble(Console.ReadLine());
            for (double i = 1; i < (n + 1); i++)
            {
                d += 1 / i;
                Console.Write(" 1/{0}+", i);
            }
            Console.WriteLine("\n");
            Console.WriteLine("The sum of {0} factors is : {1}", n, d);
        }
    }
}
