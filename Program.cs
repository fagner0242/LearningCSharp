﻿using System;
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

        Console.Write("How many contracts to this worker? ");
        int numberOfContracts = int.Parse(Console.ReadLine()!);

        for (int i = 1; i <= numberOfContracts; i++)
        {
            Console.WriteLine($"Enter #{i} contract data:");

            Console.Write("Date (DD/MM/YYYY): ");
            DateTime dateTime = DateTime.Parse(Console.ReadLine()!);

            Console.Write("Value per hour: ");
            double valuePerHour = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

            Console.Write("Duration (hours): ");
            int duration = int.Parse(Console.ReadLine()!);

            HourContract contract = new(dateTime, valuePerHour, duration);

            worker.AddContract(contract);
        }

        Console.WriteLine();

        Console.Write("Enter month and yeat to calculate income (MM/YYYY): ");
        string monthAndYear = Console.ReadLine()!;

        int month = int.Parse(monthAndYear.Substring(0, 2));

        int year = int.Parse(monthAndYear.Substring(3));

        Console.Write("Name: ");
        Console.WriteLine(worker.Name);

        Console.WriteLine("Department: ");
        Console.WriteLine(worker.Department!.Name);

        Console.WriteLine($"Income for {monthAndYear}: {worker.Income(year, month):F2}");
    }
}