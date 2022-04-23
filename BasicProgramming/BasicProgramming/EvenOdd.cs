using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgramming
{
    internal class EvenOdd
    {
        public void evenOdd()
        {
            Console.WriteLine("Enter the number: ");
            var num = Convert.ToDouble(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine("Number is Even");
            }
            else
                Console.WriteLine("Number is Odd");
        }
    }
}
