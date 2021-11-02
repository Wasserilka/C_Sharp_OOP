using System;

namespace Lesson_3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            var str = "Hello World!";
            Console.WriteLine(Reverse(str));
        }

        static string Reverse(string str)
        {
            var strReversed = "";
            for (int i = str.Length-1; i>=0; i--)
            {
                strReversed += str[i];
            }
            return strReversed;
        }
    }
}
