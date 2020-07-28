using System;
using System.Collections.Generic;
using System.Net;
using System.Runtime.CompilerServices;
using System.Security;
using System.Security.Cryptography.X509Certificates;

namespace BankApp1
{
    class Program
    {
        enum BankOptions
        {
            Register =1,
            LogIn =2,
            CloseBankApp = 3

        }
        static void Main(string[] args)
        {
            foreach ( var item in Bank.AllCustomers)
            {
                Console.WriteLine($"{item.CustomerFullName} {item.CustomerEmail} {item.Password}");
            }
                
            Bank myBank = new Bank();
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -" );
            Console.WriteLine("Welcome to the Most Wonderful Bank");
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -" );
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -"); 
            Console.WriteLine("What Would you like to do?");
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -");


            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -");

            Console.WriteLine("To Register Press ====================>          1");
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -");
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -");

            Console.WriteLine("To Log In Press ======================>          2");
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -");

            Console.WriteLine("To Exit our wonderful Bank Press ===============> 3");
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -");

            Console.WriteLine("INPUT: ");
            int response = Convert.ToInt32(Console.ReadLine());
            if (response < 1 && response > 2) 
            {

                throw new ArgumentOutOfRangeException(nameof(response), "Please Input  1    ,     2     or  3");
            }
            //Create an Account
            if (response == 1)
            {
                Console.WriteLine("Enter your First Name: ");
                string firstName = Console.ReadLine();
                Console.WriteLine("Enter your LastName: ");
                string lastName = Console.ReadLine();

                Console.WriteLine("Enter your Email: ");
                string Email = Console.ReadLine();
             
                Console.WriteLine("Enter your Password");
                string password = Console.ReadLine();
                Bank.NewCustomer(firstName, password, Email, lastName);
                Console.WriteLine("Successfully Registered!!!");
                
            }
            else
            {
                Console.WriteLine("Please Enter your  First Name and your Password: ");
                Console.WriteLine("FIRST NAME: ");
                string firstName1 = Console.ReadLine();
                Console.WriteLine("PASSWORD: ");
                string password1 = Console.ReadLine();
                Bank.LogIn(firstName1, password1);

                Console.WriteLine("==========(DEPOSIT) =====================> PRESS  1");
                Console.WriteLine("==========(WITHRAWAL) ===================> PRESS  2");
                Console.WriteLine("==========(BALANCE) =====================> PRESS  3");
                Console.WriteLine(" =========(TRANSFER)=====================> PRESS  4");
                Console.WriteLine("========(ACCOUNT HISTORY)================> PRESS  5");
            }


            //Customer kay = new Customer();
            //kay.CustomerFirstName = "Lamba";
            //kay.CustomerLastName = "Lord";
            //kay.CustomerEmail = "l.lamba@gmail.com";
            ////Console.WriteLine(kay.CustomerFullName);
            ////Console.WriteLine(kay.CustomerId);
            ////Console.WriteLine(kay.CustomerEmail);
            //kay.CreateAccount(kay.CustomerFullName, DateTime.Now);
            //Customer customer = new Customer();
            //customer.CustomerEmail = "kaybeebaba@gmail.com";
            //customer.CustomerFirstName = "kabir";
            //customer.CustomerLastName = "Omotoso";
            //customer.CreateAccount("kabir", DateTime.Now);
            ////foreach (var item in kay.AllAccount)
            ////{
            ////    Console.WriteLine("Customer Id                 Customer Name               Account Number            Account Type              Date Created");
            ////    Console.WriteLine($"{kay.CustomerId}               {item.AccountOwner}              {item.AccountNumber}             {item.AccountType}              {item.DateCreated}");
            ////}
            ////foreach (var item in customer.AllAccount)
            ////{
            ////    Console.WriteLine($"{kay.CustomerId}       {item.AccountBalance}      {item.AccountOwner}               {item.AccountNumber}               {item.AccountType}              {item.DateCreated}");
            ////}
            //kay.AllAccount[0].Deposit(10000, DateTime.Now, "Money from friends");
            //kay.AllAccount[0].Deposit(500000, DateTime.Now, "Money for Goods");
            //kay.AllAccount[0].Deposit(220200, DateTime.Now, "Money for travelling");
            //kay.CreateAccount(kay.CustomerFirstName, DateTime.Now);
            //kay.AllAccount[1].Deposit(2000000, DateTime.Now, "Initial Deposit");
            //kay.AllAccount[1].Deposit(503000, DateTime.Now, "Big Deposit");
            //kay.AllAccount[1].Deposit(5000, DateTime.Now, "Big Deposit");
            //kay.AllAccount[1].Withdrawal(1111, DateTime.Now, "Big Deposit");



            ////foreach (var item in kay.AllAccount[0].AllTransactions)
            ////{
            ////    Console.WriteLine($"{kay.AllAccount[0].AccountOwner} {kay.AllAccount[0].AccountNumber} {kay.AllAccount[0].AccountBalance} {item.Amount} {item.Date} {item.Notes}");
            ////}
            //// Console.WriteLine(Customer.GetAllCustomers(AllCustomers));
            //// Bank.GetAllCustomers(AllCustomers);  
            //kay.AllAccount[1].Withdrawal(2500, DateTime.Now, "Rent");
            //Console.WriteLine($"#{kay.AllAccount[0].Balance()}");
            ////foreach (var item in kay.AllAccount[1].AllTransactions)
            ////{
            //    Console.WriteLine($"{kay.CustomerFirstName} {kay.AllAccount[1].AccountNumber} {kay.AllAccount[1].AccountBalance}");
            //}
        }
    }
}
