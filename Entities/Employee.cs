using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp.Entities;

internal class Employee
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public double Salary { get; private set; }

    public Employee ()
    {

    }

    public Employee (int id, string name, double salary)
    {
        Id = id;
        Name = name;
        Salary = salary;
    }
}
