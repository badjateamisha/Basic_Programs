using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgramming
{
    internal class FlipCoin
    {
        public void flipCoin()
        {
            Console.WriteLine("Enter number of times to flip a coin");
            var N = Convert.ToDouble(Console.ReadLine());
            {
                Random rand = new Random();
                int heads = 0;
                int tails = 0;


                for (int i = 0; i < N; i++)
                {

                    int flip = rand.Next(0, 2);
                    Console.WriteLine(flip);

                    if (flip == 1)
                    {
                        Console.WriteLine("HEADS");
                        heads++;
                    }
                    else
                    {
                        Console.WriteLine("TAILS");
                        tails++;
                    }
                }
                Console.WriteLine("Heads Flipped for {0} times", heads);
                Console.WriteLine("Tails Flipped for {0} times", tails);
            }
        }
    }
}
