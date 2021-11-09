using System;

namespace Урок_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var RationalNumber1 = new RationalNumber(5, 6);
            var RationalNumber2 = new RationalNumber(7, 4);

            Console.WriteLine(RationalNumber1 == RationalNumber2);
            Console.WriteLine(RationalNumber1 != RationalNumber2);
            Console.WriteLine(RationalNumber1 > RationalNumber2);
            Console.WriteLine(RationalNumber1 < RationalNumber2);
            Console.WriteLine(RationalNumber1 >= RationalNumber2);
            Console.WriteLine(RationalNumber1 <= RationalNumber2);
            Console.WriteLine(RationalNumber1 >= RationalNumber1);
            Console.WriteLine(RationalNumber1 <= RationalNumber1);

            Console.WriteLine((RationalNumber1 + RationalNumber2).ToString());
            Console.WriteLine((RationalNumber1 - RationalNumber2).ToString());
            Console.WriteLine((RationalNumber1 * RationalNumber2).ToString());
            Console.WriteLine((RationalNumber2 / RationalNumber1).ToString());
            Console.WriteLine((RationalNumber2 % RationalNumber1).ToString());

            Console.WriteLine((int)RationalNumber2);
            Console.WriteLine((float)RationalNumber2);
            Console.WriteLine((++RationalNumber1).ToString());
            Console.WriteLine((--RationalNumber2).ToString());
        }
    }
}
