using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgramming
{
    internal class VowelConsonent
    {
        public void vowelConsosnent()
        {
            Console.WriteLine("Vowel or Consonent!");

            Console.WriteLine("Please Enter an Alphabet (A-Z or a-z) x : ");
            char x = Convert.ToChar(Console.ReadLine());



            if (x == 'A' || x == 'a')
                Console.WriteLine("Entered Alphabet is Vowel");
            else if (x == 'E' || x == 'e')
                Console.WriteLine("Entered Alphabet is Vowel");
            else if (x == 'I' || x == 'i')
                Console.WriteLine("Entered Alphabet is Vowel");
            else if (x == 'I' || x == 'i')
                Console.WriteLine("Entered Alphabet is Vowel");
            else if (x == 'U' || x == 'u')
                Console.WriteLine("Entered Alphabet is Vowel");
            else
                Console.WriteLine("Entered Alphabet is a Consonent");
        }
    }
}
