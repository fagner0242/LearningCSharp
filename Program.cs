using System;
using System.Globalization;
using System.Collections.Generic;

namespace LearningCSharp;

class Program
{
    static void Main(string[] args)
    {
        List<string> names = new List<string>();

        names.Add("Maria");
        names.Add("Bob");
        names.Add("Emmet");
        names.Add("Brown");

        foreach (string namesToShow in names)
        {
            Console.WriteLine(namesToShow);
        }
    }
}