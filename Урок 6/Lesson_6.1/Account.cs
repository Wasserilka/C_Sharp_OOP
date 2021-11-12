using System;

namespace Lesson_6
{
    public class Account
    {
        private long _num;
        private decimal _balance;
        private AccountType _type;
        private static long NumCounter = 0;

        public long Num 
        {
            get { return _num; } 
        }
        public decimal Balance
        {
            get { return _balance; }
        }
        public AccountType Type
        {
            get { return _type; }
        }

        private void GenerateNum()
        {
            NumCounter++;
            _num = NumCounter;
        }

        public Account()
        {
            GenerateNum();
        }

        public Account(decimal balance)
        {
            GenerateNum();
            _balance = balance;
        }

        public Account(AccountType type)
        {
            GenerateNum();
           _type = type;
        }

        public Account(decimal balance, AccountType type)
        {
            GenerateNum();
            _balance = balance;
            _type = type;
        }

        public void PutIntoBalance(decimal sum)
        {
            _balance += sum;
        }

        public void WithdrawFromBalance(decimal sum)
        {
           if (Balance >= sum)
            {
                _balance -= sum;
            }
            else
            {
                throw new Exception("Недостаточно средств");
            }
        }

        public void Transfer(Account to, decimal sum)
        {
            WithdrawFromBalance(sum);
            to.PutIntoBalance(sum);
        }

        public static bool operator ==(Account Account1, Account Account2) => Account1._num == Account2._num && Account1._type == Account2._type && Account1._balance == Account2._balance;
        public static bool operator !=(Account Account1, Account Account2) => !(Account1 == Account2);

        public override string ToString() => $"Номер счета: {_num}\nТип счета: {_type}\nБаланс: {_balance}";

        public override bool Equals(object obj)
        {
            if (!(obj is Account)) return false;
            return this == (Account)obj;
        }
        public override int GetHashCode() => base.GetHashCode();
    }

    public enum AccountType
    {
        payment,
        credit,
        deposit,
        budget
    }
}
