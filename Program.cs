using System;
using System.Globalization;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace LearningCSharp;

class Program
{
    static void Main(string[] args)
    {
        DateTime dateTime = DateTime.Now;

        DateTime d1 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Local);

        DateTime d2 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Utc);

        Console.WriteLine($"d1: {d1}");
        Console.WriteLine($"d1 Kind: {d1.Kind}");
        Console.WriteLine($"d1 To Local: {d1.ToLocalTime()}");
        Console.WriteLine($"d1 To Utc: {d1.ToUniversalTime()}");

        Console.WriteLine(dateTime);
        Console.WriteLine(dateTime.ToUniversalTime());

        Console.WriteLine(d2);
    }
}