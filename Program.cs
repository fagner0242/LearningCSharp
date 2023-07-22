using System;
using System.Globalization;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace LearningCSharp;

class Program
{
    static void Main(string[] args)
    {
        //DateTime d = new DateTime(2001, 8, 15, 13, 45, 58, 275);
        //Kind: Unspecified

        DateTime d = DateTime.Now;
        //Kind: Local

        Console.WriteLine(d);
        Console.WriteLine(d.Date);
        Console.WriteLine(d.Day);
        Console.WriteLine(d.DayOfWeek);
        Console.WriteLine(d.DayOfYear);
        Console.WriteLine(d.Hour);
        Console.WriteLine(d.Kind);
        Console.WriteLine(d.Millisecond);
        Console.WriteLine(d.Minute);
        Console.WriteLine(d.Month);
        Console.WriteLine(d.Second);
        Console.WriteLine(d.Ticks);
        Console.WriteLine(d.TimeOfDay);
        Console.WriteLine(d.Year);
    }
}