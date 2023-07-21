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

        Console.WriteLine(d1);
        Console.WriteLine(d1.Ticks);
    }
}