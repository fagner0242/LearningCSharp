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

        string originalSubstring = original.Substring(3);
        //string originalSubstring = original[3..];
        //Using range operator!!!

        //string originalSubstringLength = original.Substring(3, 5);
        string originalSubstringLength = original[3..5];

        string originalCharReplaced = original.Replace('a', 'x');
        string originalStringReplaced = original.Replace("abc", "xyz");

        bool nullTest = String.IsNullOrEmpty(original);
        bool nullTest2 = String.IsNullOrWhiteSpace(original);

        Console.WriteLine($"Original: -{original}-");
        Console.WriteLine($"To Upper: -{originalToUpper}-");
        Console.WriteLine($"To Lower: -{originalToLower}-");
        Console.WriteLine($"Trim: -{originalTrimmed}-");
        Console.WriteLine($"Index of ('bc'): -{originalSearching}-");
        Console.WriteLine($"Last index of ('bc'): -{originalSearchingLast}-");
        Console.WriteLine($"Substring(3): -{originalSubstring}-");
        Console.WriteLine($"SubstringLength(3, 5): -{originalSubstringLength}-");
        Console.WriteLine($"Replace('a', 'x': -{originalCharReplaced}-)");
        Console.WriteLine($"Replace('abc', 'xyz')-{originalStringReplaced}-");
        Console.WriteLine($"Is null or empty: {nullTest}");
        Console.WriteLine($"Is null or white space: {nullTest2}");
    }
}