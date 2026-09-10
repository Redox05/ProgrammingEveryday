using System;
using System.Collections.Generic;
using System.Text;

namespace Day002BankAccount
{
    public class SavingsAccount:BankAccount
    {
        public decimal InterestRate{ get; private set; }
        public void SetInterestRate(decimal interestRate){
            if(interestRate>0){
                InterestRate = interestRate;
            }
            else{
                throw new ArgumentOutOfRangeException($"Interest rate must be greater than zero");
            }
        }
        public SavingsAccount(string accountNumber, string owner, decimal balance, decimal interestRate):base(accountNumber,owner,balance){
            SetInterestRate(interestRate);
        }
        public override decimal CalculateMonthlyBenefit()
        {
            return Balance * InterestRate;
        }
    }
}
