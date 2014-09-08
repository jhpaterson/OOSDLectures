using System;


namespace CustomException
{
    public class Account
    {
        private decimal balance;

        public Account()
        {
            balance = 0.0m;
        }

        public Account(decimal amount)
        {
            balance = amount;
        }

        public void Withdraw(decimal amount)
        {
            decimal newBalance = balance - amount;
            if (newBalance < 0.0m)
            {
                throw new OverdrawnException(newBalance);
            }
            balance = balance - amount;
        }
    }
}
