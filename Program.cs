using System;
using System.Globalization;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace LearningCSharp;

class Program
{
    static void Main(string[] args)
    {
        double price = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

        double descount = (price < 20.0) ? price * 0.1 : price * 0.05;

        //if (price < 20.0)
        //    descount = price * 0.1;
        //else
        //    descount = price * 0.05;

        Console.WriteLine(descount);
    }
}