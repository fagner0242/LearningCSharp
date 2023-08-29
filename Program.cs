using LearningCSharp.Entities;
using System;
using System.Globalization;
using System.Reflection.Metadata.Ecma335;

namespace LearningCSharp;

class Program
{
    static void Main(string[] args)
    {
        Account acc = new Account(1001, "Alex", 0.0);

        BusinessAccount bacc = new BusinessAccount(1002, "Maria", 0.0, 500.0);

        //UPCASTING 

        Account acc1 = bacc;
        Account acc2 = new BusinessAccount(1003, "Bob", 0.0, 200.0);
        Account acc3 = new SavingsAccount(1003, "Bob", 0.0, 0.01);

        //DOWNCASTING

        BusinessAccount acc4 = acc2 as BusinessAccount;
        if (acc4 is not null)
        {
            acc4.Loan(150.0);
            Console.WriteLine(acc4.Balance);
        }
        
        if (acc3 is BusinessAccount)
        {
            BusinessAccount acc5 = (BusinessAccount)acc3;
            acc5.Loan(200.0);
            Console.WriteLine("Loan!");
        }

        if (acc3 is SavingsAccount)
        {
            SavingsAccount acc5 = acc3 as SavingsAccount;
            acc5.UpdateBalance();
            Console.WriteLine("Update!");
        }
    }
} 
