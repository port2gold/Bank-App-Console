using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BankApp1
{
     public class Customer
    {
        private static int CustomerIdSeed = 1;
        public Customer(string firstName, string password, string _Email, string _lastName)
        {   
            Password = password;
            CustomerFirstName = firstName;
            CustomerId = CustomerIdSeed.ToString();
            CustomerIdSeed++;
            CustomerEmail = _Email;
            CustomerLastName = _lastName;

        }

        public Customer()
        {
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
        public static List<Account> AllAccount = new List<Account>();

        public void CreateAccount(string name, DateTime date)
        {
            AllAccount.Add(new Account(name, date));
        }
       
       


    }
}
