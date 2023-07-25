using System;
using System.Globalization;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace LearningCSharp;

class Program
{
    static void Main(string[] args)
    {
        TimeSpan t = new TimeSpan(2, 3, 5, 7, 11);

        TimeSpan t1 = TimeSpan.MaxValue;
        TimeSpan t2 = TimeSpan.MinValue;
        TimeSpan t3 = TimeSpan.Zero;

        Console.WriteLine(t);
        Console.WriteLine(t1);
        Console.WriteLine(t2);
        Console.WriteLine(t3);

        Console.WriteLine($"Days: {t.Days}");
        Console.WriteLine($"Hours: {t.Hours}");
        Console.WriteLine($"Minutes: {t.Minutes}");
        Console.WriteLine($"MIlliseconds: {t.Milliseconds}");
        Console.WriteLine($"Seconds: {t.Seconds}");
        Console.WriteLine($"Ticks: {t.Ticks}");

        Console.WriteLine($"TotalDays: {t.TotalDays}");
        Console.WriteLine($"TotalHours: {t.TotalHours}");
        Console.WriteLine($"TotalMinutes: {t.TotalMinutes}");
        Console.WriteLine($"TotalSeconds: {t.TotalSeconds}");
        Console.WriteLine($"TotalMilliseconds: {t.TotalMilliseconds}");

    }
}