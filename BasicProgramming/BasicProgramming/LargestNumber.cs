using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgramming
{
    internal class LargestNumber
    {
        public void largest()
        {
            Console.WriteLine("Enter the values of a ,b and c");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());

            if (a > b)
            {
                if (a > c)
                {
                    Console.Write("{0} is the largest value ", a);
                }
                else
                {
                    Console.Write("{0} is the largest value ", c);
                }
            }
            else if (b > c)
                Console.Write("{0} is the largest value ", b);
            else
                Console.Write("{0} is the largest value ", c);
        }
    }
}
