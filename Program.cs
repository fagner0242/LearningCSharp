using System;
using System.Globalization;
using System.Collections.Generic;
using System;
using LearningCsharp.Entities;
using LearningCSharp.Entities.Enums;

namespace LearningCSharp;

class Program
{
    static void Main(string[] args)
    {
        Order order = new()
        {
            Id = 1080,
            Moment = DateTime.Now,
            Status = OrderStatus.PendingPayment
        };

        Console.WriteLine(order);
    }
}