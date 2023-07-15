using System;
using System.Globalization;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace LearningCSharp;

class Program
{
    static void Main(string[] args)
    {
        string[] vect = Console.ReadLine()!.Split(' ');

        int lines = int.Parse(vect[0]);
        int columns = int.Parse(vect[1]);

        int[,] mat = new int[lines, columns];

        for (int i = 0; i < lines; i++)
        {
            string[] vector = Console.ReadLine()!.Split(' ');

            for (int j = 0; j < columns; j++)
            {
                mat[i, j] = int.Parse(vector[j]);
            }
        }

        int number = int.Parse(Console.ReadLine()!);

        for (int i = 0; i < lines; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                if (mat[i, j] == number)
                {
                    Console.WriteLine($"Position {i}, {j}:");

                    if (j > 0)
                    {
                        Console.WriteLine($"Left: {mat[i, j - 1]}");
                    }
                    
                    if (i > 0)
                    {
                        Console.WriteLine($"Up: {mat[i - 1, j]}");
                    }

                    if (j < columns)
                    {
                        Console.WriteLine($"Right: {mat[i, j + 1]}");
                    }

                    if (i < lines)
                    {
                        Console.WriteLine($"Down: {mat[i + 1, j]}");
                    }
                }

                
            }
        }
    }
}