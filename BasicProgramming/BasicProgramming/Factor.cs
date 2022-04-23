using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgramming
{
    internal class Factor
    {
        public void Primefactors()
        {
            Console.WriteLine("Enter the value : ");
            int V = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Prime factors of {0} are : ", V);
            for (int i = 2; V > 1; i++)
            {
                while (V % i == 0)
                {
                    V /= i;
                    Console.WriteLine(i);
                }
            }
        }
    }
}
