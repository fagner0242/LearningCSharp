using System;
using System.Globalization;
using System.Collections.Generic;
using System;
using LearningCSharp.Entities;
using LearningCSharp.Entities.Enums;

namespace LearningCSharp;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter department's name: ");
        string departmentsName = Console.ReadLine()!;

        Console.WriteLine("Enter worker data: ");

        Console.Write("Name: ");
        string name = Console.ReadLine()!;

        Console.Write("Level (Junior/MidLevel/Senior): ");
        WorkerLevel workerLevel = Enum.Parse<WorkerLevel>(Console.ReadLine()!);

        Console.Write("Base Salary: ");
        double baseSalary = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

        Department department = new(departmentsName);

        Worker worker = new(name, workerLevel, baseSalary, department);

        Console.Write("How many contracts to this worker? ");
        int contracts = int.Parse(Console.ReadLine()!);

        for (int i = 1; i <= contracts; i++)
        {
            Console.WriteLine($"Enter #{i} contract data:");

            Console.Write("Date (DD/MM/YYYY): ");
            DateTime date = DateTime.Parse(Console.ReadLine()!);

            Console.Write("Value per hour: ");
            double valuePerHour = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

            Console.Write("Duration (Hours): ");
            int hours = int.Parse(Console.ReadLine()!);

            HourContract contract = new(date, valuePerHour, hours);

            worker.AddContract(contract);
        }

        Console.WriteLine();

        Console.Write("Enter month and year to calculate income (MM/YYYY): ");
        string monthAndYear = Console.ReadLine()!;

        int month = int.Parse(monthAndYear[0..2]);
        int year = int.Parse(monthAndYear[3..]);

        Console.WriteLine($"Name: {worker.Name}");
        Console.WriteLine($"Department: {worker.Department}");
        Console.WriteLine($"Income for {month}/{year}: {worker.Income(year, month).ToString("F2", CultureInfo.InvariantCulture)}");
    }
}