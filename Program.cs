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

        string date = d.ToLongDateString();
        string time = d.ToLongTimeString();
        string shortDate = d.ToShortDateString();
        string shortTime = d.ToShortTimeString();

        string stringFormatation = d.ToString("yyyy-MM-dd HH:mm:ss");
        string formatationMilliSeconds = d.ToString("yyyy-MM-dd HH:mm:ss.fff");

        Console.WriteLine(d);
        Console.WriteLine($"{date} {time}");
        Console.WriteLine(shortDate);
        Console.WriteLine(shortTime);
        Console.WriteLine(d.ToString());
        Console.WriteLine(stringFormatation);
        Console.WriteLine(formatationMilliSeconds);
    }
}