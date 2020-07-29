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
            Register = 1,
            LogIn = 2,
            CloseBankApp = 3

        }
        static void Main(string[] args)
        {
            //foreach (var item in Bank.AllCustomers)
            //{
            //    Console.WriteLine($"{item.CustomerFullName} {item.CustomerEmail} {item.Password}");
            //}

            //Bank myBank = new Bank();
            bool signIn = true;
            while (signIn == true)
            {
                Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -");
                Console.WriteLine("Welcome to the Most Wonderful Bank");
                Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -");
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
                // Regiser  and Create an Account
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
                    foreach (var items in Bank.AllCustomers)
                    {
                        if (items.CustomerFirstName == firstName)
                        {
                            items.CreateAccount(items.CustomerFullName, DateTime.Now);
                            Console.WriteLine("Account Creation Successful");
                            foreach (var item in Customer.AllAccount)
                            {
                                for (int i = 0; i < Customer.AllAccount.Count; i++)
                                {
                                    if (Customer.AllAccount[i].AccountOwner == items.CustomerFullName)
                                    {
                                        Console.WriteLine($"Your Account Number is {Customer.AllAccount[i].AccountNumber}");

                                    }
                                }


                            }
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Please Enter your  First Name and your Password: ");
                    Console.WriteLine("FIRST NAME: ");
                    string firstName1 = Console.ReadLine();
                    Console.WriteLine("PASSWORD: ");
                    string password1 = Console.ReadLine();
                    Bank.LogIn(firstName1, password1);




                    Console.WriteLine("==========(DEPOSIT) =======================> PRESS  1");
                    Console.WriteLine("==========(TRANSFER) ======================> PRESS  2");
                    Console.WriteLine("==========(BALANCE) =======================> PRESS  3");
                    Console.WriteLine(" =========(WITHDRAWAL)======================> PRESS  4");
                    Console.WriteLine(" =======(OPEN ANOTHER ACCOUNT)==============> PRESS  5");
                    Console.WriteLine("========(ACCOUNT HISTORY)===================> PRESS  6");
                    Console.WriteLine("===========(LOG OUT=========================> PRESS  7");
                    int answer = Convert.ToInt32(Console.ReadLine());
                    if (answer == 1)
                    {
                        // foreach (var item in Bank.AllCustomers)
                        {
                            Console.WriteLine("Enter Account Number: ");
                            string accountNumber = Console.ReadLine();


                            Console.WriteLine("Enter the Amount to Deposit: ");
                            decimal amount = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter Note: ");
                            string note = Console.ReadLine();
                            for (int i = 0; i < Customer.AllAccount.Count; i++)
                            {
                                if (Customer.AllAccount[i].AccountNumber == accountNumber)
                                {
                                    Customer.AllAccount[i].Deposit(amount, DateTime.Now, note);
                                }
                            }
                        }
                    }
                    else if (answer == 2)
                    {
                        {
                            Console.WriteLine("Enter Receiver Account Number: ");
                            string accountNumber1 = Console.ReadLine();
                            Console.WriteLine("Enter Your Account Number: ");
                            string accountNumber2 = Console.ReadLine();


                            Console.WriteLine("Enter the Amount to Deposit: ");
                            decimal amount = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter Note: ");
                            string note = Console.ReadLine();
                            for (int i = 0; i < Customer.AllAccount.Count; i++)
                            {
                                if (Customer.AllAccount[i].AccountNumber == accountNumber1)
                                {
                                    Customer.AllAccount[i].Deposit(amount, DateTime.Now, note);
                                }

                                if (Customer.AllAccount[i].AccountNumber == accountNumber2)
                                {
                                    Customer.AllAccount[i].Withdrawal(amount, DateTime.Now, note);
                                }
                            }
                        }
                    }
                    else if (answer == 3)
                    {
                        Console.WriteLine("Enter Your Account Number: ");
                        string _accountNumber = Console.ReadLine();
                        foreach (var item in Customer.AllAccount)
                        {
                            if (item.AccountNumber == _accountNumber)
                            {
                                item.Balance();
                            }
                        }
                    }
                    else if (answer == 4)
                    {
                        Console.WriteLine("Enter the Amount to Deposit: ");
                        decimal amount = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Note: ");
                        string note = Console.ReadLine();
                        Console.WriteLine("Enter Your Account Number: ");
                        string _accountNumber = Console.ReadLine();
                        foreach (var item in Customer.AllAccount)
                        {
                            if (item.AccountNumber == _accountNumber)
                            {
                                item.Withdrawal(amount, DateTime.Now, note);
                            }
                        }
                    }
                    else if (answer == 5)
                    {
                        Console.WriteLine("ENTER YOUR FIRST NAME");
                        string _firstName = Console.ReadLine();
                        foreach (var item in Bank.AllCustomers)
                        {
                            if (item.CustomerFirstName == _firstName)
                            {
                                item.CreateAccount(item.CustomerFullName, DateTime.Now);
                            }
                        }
                    }
                    else if (answer == 6)
                    {
                        Console.WriteLine("To check your Accoun History: ");
                        Console.WriteLine("ENTER YOUR ACCOUNT NUMBER: ");
                        string _accountNumber = Console.ReadLine();
                        foreach (var item in Customer.AllAccount)
                        {
                            if (item.AccountNumber == _accountNumber)
                            {
                                foreach (var items in item.AllTransactions)
                                {
                                    Console.WriteLine("     Full Name               Account Number          AccountType             Amount        Account Balance       Note        Dates");
                                    Console.WriteLine($"{item.AccountOwner}     {item.AccountNumber}    {item.AccountType}     {items.Amount}       {item.AccountBalance}    {items.Notes}   {items.Date}");
                                }
                            }
                        }

                    }
                    else
                    {
                        signIn = false;
                    }


                }

            }
            
        }



    }

}













    //else
    //{
    //    //Console.WriteLine("Enter Your Account Number: ");
    //string _accountNumber = Console.ReadLine();
    //foreach (var item in Customer.AllAccount)
    //{
    //    if (item.AccountNumber == _accountNumber)
    //    {

    //    }


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



