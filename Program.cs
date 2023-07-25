using System;
using System.Globalization;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace LearningCSharp;

class Program
{
    static void Main(string[] args)
    {
        DateTime d1 = DateTime.Now;

        DateTime d2 = d1.AddDays(3);

        TimeSpan difference = d2.Subtract(d1);

        Console.WriteLine(difference);

    }
}