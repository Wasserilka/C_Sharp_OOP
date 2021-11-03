namespace Lesson_2
{
    public class Account
    {
        private long _num;
        private decimal _balance;
        private AccountType _type;
        private static long numCounter = 0;

        public long num 
        {
            get { return _num; } 
        }
        public decimal balance
        {
            get { return _balance; }
        }
        public AccountType type
        {
            get { return _type; }
        }

        private void GenerateNum()
        {
            numCounter++;
            _num = numCounter;
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
           if (balance >= sum)
            {
                _balance -= sum;
            }
        }
    }

    public enum AccountType
    {
        payment,
        credit,
        deposit,
        budget
    }
}
