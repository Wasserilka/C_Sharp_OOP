using System;

namespace Lesson_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var Account1 = new Account(100m, AccountType.deposit);
            var Account2 = new Account(199.99m, AccountType.credit);

            Console.WriteLine(Account1 == Account2);
            Console.WriteLine(Account1 == Account1);
            Console.WriteLine(Account1.Equals(Account1));
            Console.WriteLine(Account1.Equals(Account2));
            Console.WriteLine(Account1.Equals(null));
            Console.WriteLine(Account1.ToString());
            Console.WriteLine(Account2.ToString());
        }
    }
}
