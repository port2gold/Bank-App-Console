using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp1
{
    public class Bank
    {
        public static List<Customer> AllCustomers = new List<Customer>();
        public static void NewCustomer(string firstName, string password, string Email, string LastName)
        {
            AllCustomers.Add(new Customer(firstName, password, Email, LastName));
        }

        //public void GetAllCustomers(List<Customer> customers)
        //{
        //    int i = 0;
        //    foreach (var item in customers)
        //        Console.WriteLine($"{item.CustomerId}{item.CustomerFirstName} {item.CustomerEmail} {item.AllAccount[i].AccountNumber} {item.AllAccount[i].AccountBalance} ");
        //    //i = i + 1;
        //    i++;
        //}
        //public void RegisterCustomer()
        //{
        //    AllCustomers.Add(new Customer(string firstName,string password));
        //}


        public static void LogIn(string firstName, string password)
        {
            Console.WriteLine("Please enter your Name and your Password");
            Console.WriteLine("First Name: "); 
            firstName = Console.ReadLine();
            Console.WriteLine("Password: ");
            password = Console.ReadLine();
            foreach (var item in AllCustomers)
            {
                if (item.CustomerFirstName == firstName && item.Password == password)
                {
                    Console.WriteLine("SUCCESSFUL SIGN IN");
                }
            }
        }
    }
}
