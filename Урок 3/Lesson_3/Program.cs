using System;

namespace Lesson_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var NewAccount_1 = new Account(100.05m);
            var NewAccount_2 = new Account(99.99m);

            NewAccount_1.Transfer(NewAccount_2, 50m);

            Console.WriteLine($"Номер счета: {NewAccount_1.num}\nБаланс: {NewAccount_1.balance}");
            Console.WriteLine($"Номер счета: {NewAccount_2.num}\nБаланс: {NewAccount_2.balance}");
        }
    }
}
