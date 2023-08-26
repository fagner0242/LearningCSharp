using LearningCSharp.Entities;
using System;
using System.Globalization;
using System.Reflection.Metadata.Ecma335;

namespace LearningCSharp;

class Program
{
    static void Main(string[] args)
    {
        BusinessAccount account = new(8010, "Maria", 500.50, 5000.0);

        Console.WriteLine(account.Balance);
    }
}
