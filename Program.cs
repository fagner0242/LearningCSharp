using System;
using System.Globalization;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace LearningCSharp;

class Program
{
    static void Main(string[] args)
    {
        TimeSpan t1 = new TimeSpan(0, 1, 30);

        TimeSpan t2 = new(900000000L);

        TimeSpan t3 = new(5, 7, 30, 20);
        TimeSpan t4 = new(5, 7, 30, 20, 325);

        Console.WriteLine(t1);
        Console.WriteLine(t1.Ticks);

        Console.WriteLine(t2);

        Console.WriteLine(t3);
        Console.WriteLine(t4);
    }
}