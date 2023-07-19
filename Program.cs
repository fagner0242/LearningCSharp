using System;
using System.Globalization;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace LearningCSharp;

class Program
{
    static void Main(string[] args)
    {
        string original = "abcde FGHIJ ABC abc DEFG   ";

        string originalToUpper = original.ToUpper();
        string originalToLower = original.ToLower();
        string originalTrimmed = original.Trim();
        int originalSearching = original.IndexOf("bc");
        int originalSearchingLast = original.LastIndexOf("bc");

        Console.WriteLine($"Original: -{original}-");
        Console.WriteLine($"To Upper: -{originalToUpper}-");
        Console.WriteLine($"To Lower: -{originalToLower}-");
        Console.WriteLine($"Trim: -{originalTrimmed}-");
        Console.WriteLine($"Index of ('bc'): {originalSearching}");
        Console.WriteLine($"Last index of ('bc'): {originalSearchingLast}");
    }
}