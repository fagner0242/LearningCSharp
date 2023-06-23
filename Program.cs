using LearningCSharp.Entities;

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

        string txt = OrderStatus.pendingPayment.ToString();

        OrderStatus os = Enum.Parse<OrderStatus>(txt);
        //or
        //OrderStatus os = Enum.Parse<OrderStatus>("pendingPayment");

        Console.WriteLine(txt);
        Console.WriteLine(os);
    }
}
