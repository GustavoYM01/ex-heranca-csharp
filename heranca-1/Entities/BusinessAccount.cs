using System;

namespace heranca_1.Entities
{
    class BusinessAccount : Account
    {

        public double LoanLimit { get; set; }

        public BusinessAccount()
        {
        }

        public BusinessAccount(int number, string holder, 
            double balance, double loanLimit) : base(number, 
                holder, balance)
        {
            LoanLimit = loanLimit;
        }

        public void Loan(double amount)
        {
            if(amount <= LoanLimit)
            {
                Balance += amount;
            }
            else
            {
                Console.WriteLine("Loan not granted!");
            }
        }
    }
}
