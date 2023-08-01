using System;
using LearningCSharp.Entities.Enums;

namespace LearningCsharp.Entities;

internal class Order
{
    public int Id { get; set; }

    public DateTime Moment { get; set; }

    public OrderStatus Status { get; set; }

    public override string ToString()
    {
        return $"{Id}\n" +
            $"{Moment}\n" +
            $"{Status}\n";
    }
}