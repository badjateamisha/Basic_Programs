// See https://aka.ms/new-console-template for more information
using BasicProgramming;


Console.WriteLine("Basic programming");


while (true)
{
    Console.WriteLine("----------------------------------------");
    Console.WriteLine("\nChoose the Program to be executed :\n1)Flipcoin\n2)Leapyear\n3)Evenodd\n4)Harmonic Series\n5)Power Of 2\n6)Prime Factors\n7)Quotient And Remainder\n8)Swapping Of numbers\n9)Vowel and Consonent\n10)primefactors");
    int option = Convert.ToInt32(Console.ReadLine());
    switch (option)
    {
        case 1:
            FlipCoin flipcoin = new();
            flipcoin.flipCoin();
            break;

        case 2:
            LeapYear Leapyear = new();
            LeapYear.leapYear();
            break;

        case 3:
            EvenOdd evenodd = new();
            evenodd.evenOdd();
            break;

        case 4:
            Harmonic harmonic = new();
            harmonic.HarmonicSeries();
            break;

        case 5:
            PowerOf2 power = new();
            power.Powerof2();
            break;

        case 6:
            Factor factors = new();
            factors.Primefactors();
            break;

        case 7:
            QuotientRemainder qr = new();
            qr.quotientRemainder();
            break;

        case 8:
            SwapNumbers swap = new();
            swap.swapNumbers();
            break;

        case 9:
            VowelConsonent vowel = new();
            vowel.vowelConsosnent();
            break;

        case 10:
            LargestNumber large = new();
            large.largest();
            break;
    }
}
