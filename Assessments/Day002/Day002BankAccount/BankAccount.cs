using System;
using System.Collections.Generic;
using System.Text;

namespace Day002BankAccount
{
    public abstract class BankAccount
    {
        public string AccountNumber { get; private set; }
        public string Owner { get; private set; }
        public decimal Balance { get; private set; }

        public void SetAccountNumber(string accountNumber){
            if(accountNumber==null){
                throw new ArgumentNullException($"Account Number cannot be empty");
            }
            else{
                AccountNumber = accountNumber;
            }
        }
        public void SetOwner(string owner){
            if(owner==null){
                throw new ArgumentNullException($"Owner cannot be empty.");
            }
            else{
                Owner = owner;
            }
        }
        public void SetBalance(decimal balance){
            if(balance<0){
                throw new ArgumentOutOfRangeException($"Balance cannot be negative when the account is created");
            }
            else{
                Balance = balance;
            }
        }

        public BankAccount(string accountNumber, string owner, decimal balance)
        {
            SetAccountNumber(accountNumber);
            SetOwner(owner);
            SetBalance(balance);
        }

        public decimal Deposit(decimal amount){
            if(amount<=0){
                throw new ArgumentOutOfRangeException($"Deposit must be greater than zero.");
            }
            return Balance + amount;
        }
        public decimal Withdraw(decimal amount){
            if(amount>Balance){
                throw new ArgumentOutOfRangeException($"Not enough funds");
            }
            return Balance - amount;
        }
        public abstract decimal CalculateMonthlyBenefit();
    }
}
