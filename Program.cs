using System;

namespace LearningCSharp;

class Program
{
    static void Main(string[] args)
    {
        Order order = new()
        {
            Id = 10,
            OrderTime = DateTime.Now,
            Status = OrderStatus.pendingPayment
        };

        Console.WriteLine(order);
    }
}
