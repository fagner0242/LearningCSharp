using System;
using System.Globalization;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace LearningCSharp;

class Program
{
    static void Main(string[] args)
    {
        string test = "abcd efghijk lmno";

        string indexTest = test[3..8];

        Console.WriteLine(indexTest);
    }
}