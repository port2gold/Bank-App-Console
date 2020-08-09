using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp1
{
    //Account Related Fields
    public class Account
    {
        private static int AccountNumberSeed = 0123456789;


        public string AccountNumber { get; }
        public string AccountOwner { get; }
        public string AccountType = "Savings";
        public DateTime DateCreated { get; }

        //Account Balance
        public decimal AccountBalance
        {
            get
            {
                decimal AccountBalance = 0;
                foreach (var item in AllTransactions)
                {
                    AccountBalance += item.Amount;
                }
                return AccountBalance;
            }
           private set{ }
        }
        public Account(string name, DateTime date)
        {

            AccountNumber = AccountNumberSeed.ToString();
            AccountNumberSeed++;
            DateCreated = date;
            AccountOwner = name;
        }
        public List<Transactions> AllTransactions = new List<Transactions>();
        public void Deposit(decimal amount, DateTime date, string note)
        {
            // AccountBalance += amount;
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Positive Amount Only!");
            }

            AllTransactions.Add(new Transactions(amount, date, note));
        }
        //All Transactions List and  Account Withdrawal
        public void Withdrawal(decimal amount, DateTime date, string note)
        {
            if (amount < 0 && AccountBalance - amount < 100)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Positive Amount Only!");
            }
            AccountBalance -= amount;
            AllTransactions.Add(new Transactions(-amount, date, note));
            
        }
        //Account Balance Check
        public string Balance()
        {
            return AccountBalance.ToString();
        }
        //Transfer
        public void Transfer(string _AccountNumber, decimal amount, DateTime date, string note )
        {
            foreach (var item in Customer.AllAccount)
            {
                if (item.AccountNumber == _AccountNumber)
                {
                    item.Deposit(amount, DateTime.Now, note);
                }
                this.Withdrawal(amount, DateTime.Now, note);
            }
                  
        }



    }
}
