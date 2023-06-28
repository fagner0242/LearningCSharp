using System;
using System.Globalization;
using LearningCSharp.Entities;
using LearningCSharp.Entities.Enums;

namespace LearningCSharp;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter department's name: "); 
        string departmentName = Console.ReadLine()!;

        Console.WriteLine("Enter worker data: ");

        Console.Write("Name: ");
        string name = Console.ReadLine()!;

        Console.Write("Level (Junior/MidLevel/Sênior): ");
        WorkerLevel workerLevel = Enum.Parse<WorkerLevel>(Console.ReadLine()!);
        //Converting MidLevel string para enum

        Console.Write("Base salary: ");
        double baseSalary = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

        Department department = new(departmentName);

        Worker worker = new(name, workerLevel, baseSalary, department);
    }
}