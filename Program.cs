using System;
using System.Globalization;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace LearningCSharp;

class Program
{
    static void Main(string[] args)
    {
        DateTime dateTime = DateTime.Parse("2000-08-15 13:05:58");

        DateTime dateTime2 = DateTime.Parse("2000-08-15T13:05:58Z");

        Console.WriteLine(dateTime);
        Console.WriteLine($"DateTime Kind: {dateTime.Kind}");
        Console.WriteLine($"DateTime To Local: {dateTime.ToLocalTime()}");
        Console.WriteLine($"DateTime To Utc: {dateTime.ToUniversalTime()}");

        Console.WriteLine();

        Console.WriteLine(dateTime2);
        Console.WriteLine($"DateTime2 Kind: {dateTime2.Kind}");
        Console.WriteLine($"DateTime2 To Local: {dateTime2.ToLocalTime()}");
        Console.WriteLine($"DateTime2 To Utc: {dateTime2.ToUniversalTime()}");

        Console.WriteLine(dateTime2.ToString("yyyy-MM-ddTHH:mm:ssZ"));
        Console.WriteLine(dateTime2.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ssZ"));
    }
}