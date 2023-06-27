using LearningCSharp.Entities;
using System; 

namespace LearningCSharp;

class Program
{
    static void Main(string[] args)
    {
        Department department = new();

        Console.Write("Enter department's name: ");
        department.Name = Console.ReadLine()!;

        Console.WriteLine("Enter worker data: ");

        Console.Write("Name: ");
        string name = Console.ReadLine()!;

        
    }
}