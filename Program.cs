using System;
using System.Globalization;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace LearningCSharp;

class Program
{
    static void Main(string[] args)
    {
        DateTime d = DateTime.Now;

        DateTime dateTime = new DateTime(2000, 10, 18);

        DateTime d1 = d.AddDays(7);

        DateTime d2 = d.AddHours(2);

        DateTime d3 = d.AddMinutes(5);

        Console.WriteLine(d);
        Console.WriteLine(d1);
        Console.WriteLine(d2);
        Console.WriteLine(d3);
    }
}