using System;
using System.Globalization;
using System.Collections.Generic;
using LearningCSharp.Entities;

namespace LearningCSharp;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("How many employees will be registered? ");
        int numberOfEmployees = int.Parse(Console.ReadLine()!);

        List<Employee> employees = new List<Employee>();

        for (int i = 1; i <= numberOfEmployees; i++)
        {
            Console.WriteLine($"Employee #{i}:");

            Console.Write("Id: ");
            int id = int.Parse(Console.ReadLine()!);

            Console.Write("Name: ");
            string name = Console.ReadLine()!;

            Console.Write("Salary: ");
            double salary = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

            employees.Add(new Employee(id, name, salary));
        }

        Console.Write("Enter the employee id that will have salary increase: ");
        int employeeIdForIncrease = int.Parse(Console.ReadLine()!);

        Employee employee = employees.Find(x => x.Id == employeeIdForIncrease)!;
        if (employee is not null)
        {
            Console.Write("Enter the percentage: ");
            double percentage = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
            employee.SalaryIncrease(percentage);
        }

        Console.WriteLine("Updated list of employees:");

        for (int i = 0; i < numberOfEmployees; i++)
        {
            Console.WriteLine(employees[i]);
        }
    }
}