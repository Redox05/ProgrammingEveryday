using System;
using System.Collections.Generic;
using System.Text;

namespace Day002BankAccount
{
    public class CheckingAccount : BankAccount
    {
        public decimal MonthlyFee { get; private set; }

        public void SetMonthlyFee(decimal monthlyFee)
        {
            if (monthlyFee >= 0)
            {
                MonthlyFee = monthlyFee;
            }
            else
            {
                throw new ArgumentOutOfRangeException($"Monthly fee cannot be negative");
            }
        }
        public CheckingAccount(string accountNumber, string owner, decimal balance, decimal monthlyFee) : base(accountNumber, owner, balance)
        {
            SetMonthlyFee(monthlyFee);
        }
        public override decimal CalculateMonthlyBenefit()
        {
            return -MonthlyFee;
        }
    }
}
