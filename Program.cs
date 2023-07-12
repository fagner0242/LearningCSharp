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
            double salary = double.Parse(Console.ReadLine()!);

            employees.Add(new Employee(id, name, salary));
        }

        Console.WriteLine("Enter the employee id that who will have salary increase: ");
        int searchId = int.Parse(Console.ReadLine()!);

        Employee employee = employees.Find(x => x.Id == searchId)!;
        if ()
        {

        }
    }
}