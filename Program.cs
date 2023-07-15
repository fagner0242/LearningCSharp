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
        // 3 4

        int lines = int.Parse(vect[0]);
        int columns = int.Parse(vect[1]);

        int[,] mat = new int[lines, columns];

        for (int i = 0; i < lines; i++)
        {
            string[] vector = Console.ReadLine()!.Split(' ');
            // 10 8 15 12
            //21 11 23 8
            //14 5 13 19

            for (int j = 0; j < columns; j++)
            {
                mat[i, j] = int.Parse(vector[j]);
            }
        }

        int number = int.Parse(Console.ReadLine()!);
        //8

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

                    if (j < columns - 1)
                    {
                        Console.WriteLine($"Right: {mat[i, j + 1]}");
                    }

                    if (i < lines - 1)
                    {
                        Console.WriteLine($"Down: {mat[i + 1, j]}");
                    }
                }

                
            }
        }
    }
}