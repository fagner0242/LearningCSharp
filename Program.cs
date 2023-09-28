using LearningCSharp.Entities;
using System.Globalization;

Console.Write("Enter the number of employees: ");
int numberOfEmployees = int.Parse(Console.ReadLine()!);

List<Employee> employees = new List<Employee>();

for (int i = 1; i <= numberOfEmployees; i++)
{
    Console.WriteLine($"Employee #{i} data:");

    Console.Write("OutSourced (y/n)? ");
    char outSourced = char.Parse(Console.ReadLine()!);

    Console.Write("Name: ");
    string name = Console.ReadLine()!;

    Console.Write("Hours: ");
    int hours = int.Parse(Console.ReadLine()!);

    Console.Write("Value per hour: ");
    double valuePerHour = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

    if (outSourced == 'y')
    {
        Console.Write("Addtional charge: ");
        double additionalCharge = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

        Employee outSorcedEmployee = new OutSourcedEmployee(name, hours, valuePerHour, additionalCharge);
        employees.Add(outSorcedEmployee);
    }
    else
    {
        Employee employee = new Employee(name, hours, valuePerHour);
        employees.Add(employee);
    }
}

Console.WriteLine();
Console.WriteLine("PAYMENTS: ");

foreach (Employee employee in employees)
{
    Console.WriteLine($"{employee.Name} - $ {employee.Payment().ToString("F2", CultureInfo.InvariantCulture)}");
}