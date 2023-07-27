using System;
using System.Globalization;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace LearningCSharp;

class Program
{
    static void Main(string[] args)
    {
        DateTime d1 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Local);

        DateTime d2 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Utc);

        DateTime d3 = new DateTime(2000, 8, 15, 13, 5, 58);


        Console.WriteLine(d1);
        Console.WriteLine(d2);
        Console.WriteLine(d3);
    }
}