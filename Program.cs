using System;
using System.Globalization;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace LearningCSharp;

class Program
{
    static void Main(string[] args)
    {
        int? x = null;
        int? y = 5;

        int a = x ?? 10;
        int b = y ?? 10;

        Console.WriteLine(a);
        Console.WriteLine(b);
    }
}