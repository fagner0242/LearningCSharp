using LearningCSharp.Entities;
using System;
using System.Globalization;
using System.Reflection.Metadata.Ecma335;

namespace LearningCSharp;

class Program
{
    static void Main(string[] args)
    {
        Account mainAccount = new(1001, "Alex", 500.0);
        Account savingsAccount = new SavingsAccount(1002, "Alex", 500.0, 0.01);

        mainAccount.WithDraw(10.0);
        savingsAccount.WithDraw(10.0);

        Console.WriteLine(mainAccount.Balance);
        Console.WriteLine(savingsAccount.Balance);  
    }
} 
