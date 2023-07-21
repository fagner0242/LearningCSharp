using System;
using System.Globalization;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace LearningCSharp;

class Program
{
    static void Main(string[] args)
    {
        DateTime dateTime = new DateTime(2023, 07, 20);
        DateTime dateTime2 = new DateTime(2023, 07, 20, 0, 1, 2);
        DateTime dateTime3 = new DateTime(2023, 07, 20, 0, 1, 2, 500);

        DateTime dateTime4 = DateTime.Now;
        DateTime dateTime5 = DateTime.Today;
        DateTime dateTime6 = DateTime.UtcNow;


        Console.WriteLine(dateTime);
        Console.WriteLine(dateTime2);
        Console.WriteLine(dateTime3);
        Console.WriteLine(dateTime4);
        Console.WriteLine(dateTime5);
        Console.WriteLine(dateTime6);
    }
}