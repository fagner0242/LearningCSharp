using System;
using System.Globalization;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace LearningCSharp;

class Program
{
    static void Main(string[] args)
    {
        TimeSpan t = new TimeSpan(1, 30, 30);

        TimeSpan t2 = new TimeSpan(0, 10, 5);

        TimeSpan sum = t.Add(t2);
        TimeSpan diff = t.Subtract(t2);
        TimeSpan mult = t2.Multiply(2.0);
        TimeSpan div = t.Divide(2.0);

        Console.WriteLine(sum);
        Console.WriteLine(diff);
        Console.WriteLine(mult);
        Console.WriteLine(div);
    }
}