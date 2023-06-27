using LearningCSharp.Entities.Enums;

namespace LearningCSharp.Entities;

internal class Worker
{
    public string? Name { get; set; }

    public WorkerLevel Level { get; set; }

    public double BaseSalary { get; set; }

    public Department Department { get; set; }

    public Worker ()
    {

    }
}
