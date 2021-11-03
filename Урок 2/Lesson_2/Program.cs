using System;

namespace Lesson_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var NewAccount_1 = new Account();
            var NewAccount_2 = new Account(100.05m);
            var NewAccount_3 = new Account(AccountType.credit);
            var NewAccount_4 = new Account(99.99m, AccountType.deposit);

            NewAccount_4.PutIntoBalance(5.07m);
            NewAccount_4.WithdrawFromBalance(90);
            NewAccount_4.WithdrawFromBalance(90);

            Console.WriteLine($"Номер счета: {NewAccount_4.num}\nБаланс: {NewAccount_4.balance}\nТип счета: {NewAccount_4.type}\n");
        }
    }
}
