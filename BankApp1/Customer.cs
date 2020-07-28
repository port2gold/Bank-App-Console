using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BankApp1
{
    class Customer
    {
        private static int CustomerIdSeed = 1;
        public Customer(string firstName, string password)
        {   
            Password = password;
            CustomerFirstName = firstName;
            CustomerId = CustomerIdSeed.ToString();
            CustomerIdSeed++;

        }
        public string CustomerId { get; }
        public string Password { get; set;}
        public string CustomerFirstName { get; set; }
        public string CustomerLastName { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerFullName
        {
            get
            {
                return CustomerLastName + ", " + CustomerFirstName;
            }
        }
        public  List<Account> AllAccount = new List<Account>();

        public void CreateAccount(string name, DateTime date)
        {
            AllAccount.Add(new Account(name, date));
        }
       
       


    }
}
