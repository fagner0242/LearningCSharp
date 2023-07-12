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

        names.Insert(2, "Marco");

        foreach (string namesToShow in names)
        {
            Console.WriteLine(namesToShow);
        }

        Console.WriteLine($"List count: {names.Count}");

        Console.WriteLine("--------------------------");

        string findE = names.Find(x => x[0] == 'E')!;
        Console.WriteLine($"First name with E: {findE}");

        Console.WriteLine();

        string findLastA = names.FindLast(x => x[0] == 'A')!;
        Console.WriteLine($"Last name with A");

        int findFirstB = names.FindIndex(x => x[0] == 'B');

        Console.WriteLine($"First name index with B: {findFirstB}");
    }

    static bool Test(string findA)
    {
        return findA[0] == 'E';
    }
}