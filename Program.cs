using System;
using System.Globalization;
using System.Collections.Generic;
using LearningCSharp.Entities;
using LearningCSharp.Entities.Enums;

namespace LearningCSharp;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter department's name: ");
        string departmentName = Console.ReadLine()!;

        Department department = new(departmentName);

        Console.WriteLine("Enter worker data:");

        Console.Write("Name: ");
        string name = Console.ReadLine()!;

        Console.Write("Level (Junior/MidLevel/Senior): ");
        WorkerLevel workerLevel = Enum.Parse<WorkerLevel>(Console.ReadLine()!);

        Console.Write("Base salary: ");
        double baseSalary = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

        Worker worker = new(name, workerLevel, baseSalary, department);

        Console.Write("How many contracts to this worker?");
        int contractsNumber = int.Parse(Console.ReadLine()!);

        for (int i = 1; i <= contractsNumber; i++)
        {
            Console.Write("Date (DD/MM/YYYY: )");
            DateTime date = DateTime.Parse(Console.ReadLine()!);

            Console.Write("Value per hour");
            double valuePerHour = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

            Console.Write("Duration: ");
            int hours = int.Parse(Console.ReadLine()!);

            WorkerContracts contracts = new(date, valuePerHour, hours);

            worker.Contracts.Add(contracts);
        }

        Console.WriteLine();

        Console.Write("Enter month and year to calculate income (MM/YYYY): ");
        string monthAndYear = Console.ReadLine()!;

        int month = int.Parse(monthAndYear.Substring(0, 2));
        int year = int.Parse(monthAndYear.Substring(3, 4));

        Console.WriteLine(worker.Name);
        Console.WriteLine(worker.Department.Name);
        Console.WriteLine(worker.Income(month, year));
    }
}
