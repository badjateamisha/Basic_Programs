using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgramming
{
    internal class SwapNumbers
    {
        public void swapNumbers()
        {

            Console.WriteLine("Enter the values of a and b");
            var a = Convert.ToDouble(Console.ReadLine());
            var b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Before Swap value of a = " + a + " value of b = " + b);
            a = a * b;
            b = a / b;
            a = a / b;
            Console.WriteLine("Before Swap value of a = " + a + " value of b = " + b);
        }
    }
}
