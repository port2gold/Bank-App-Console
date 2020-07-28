using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp1
{
    class Bank
    {
        public List<Customer> AllCustomers = new List<Customer>();
        //public void NewCustomer()
        //{
        //    AllCustomers.Add(new Customer());
        //}

        public void GetAllCustomers(List<Customer> customers)
        {
            int i = 0;
            foreach (var item in customers)
                Console.WriteLine($"{item.CustomerId}{item.CustomerFirstName} {item.CustomerEmail} {item.AllAccount[i].AccountNumber} {item.AllAccount[i].AccountBalance} ");
            //i = i + 1;
            i++;
        }
        public void RegisterCustomer()
        {
            AllCustomers.Add(new Customer(string firstName,string password));
        }


        public void LogIn(string firstName, string password)
        {
            Console.WriteLine("Please enter your Name and your Password");
            Console.WriteLine("First Name: "); 
            firstName = Console.ReadLine();
            Console.WriteLine("Password: ");
            password = Console.ReadLine();
           // if ()
        }
    }
}
