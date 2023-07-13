using System;
using System.Globalization;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace LearningCSharp;

class Program
{
    static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine()!);
        //3

        int[,] mat = new int[number ,number];

        for (int line = 0; line < number; line++)
        {
            string[] values = Console.ReadLine()!.Split(' ');

            for (int column = 0; column < number; column++)
            {
                mat[line, column] = int.Parse(values[column]);
            }
        }

        Console.WriteLine("Main diagonal:");

        int sum = 0;

        for (int line = 0; line < number; line++)
        {
            for (int column = 0; column < number; column++)
            {
                if (line == column)
                {
                    Console.Write($"{mat[line, column]} ");
                }

                if (mat[line, column] < 0)
                {
                    sum++;
                }
            }
        }

        Console.WriteLine();

        Console.WriteLine($"Negative numbers = {sum}");
    }
}