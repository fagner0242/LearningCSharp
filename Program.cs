using LearningCSharp.Entities;
using LearningCSharp.Entities.Enums;
using System;
using System.Globalization;
using System.Reflection.Metadata.Ecma335;

namespace LearningCSharp;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter client data:");

        Console.Write("Name: ");
        string name = Console.ReadLine()!;

        Console.Write("Email: ");
        string email = Console.ReadLine()!;

        Console.Write("Birth date (DD/MM/YYYY): ");
        DateTime birthDate = DateTime.Parse(Console.ReadLine()!);

        Client client = new Client(name, email, birthDate);

        Console.WriteLine("Enter order data:");

        Console.Write("Status: ");
        OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine()!);

        Order order = new(DateTime.Now, status, client);

        Console.Write("How many items to this order? ");
        int numberOfItems = int.Parse(Console.ReadLine()!);

        for (int i = 1; i <= numberOfItems; i++)
        {
            Console.Write("Product name: ");
            string productName = Console.ReadLine()!;

            Console.Write("Product price: ");
            double productPrice = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

            Console.WriteLine("Quantity: ");
            int quantity = int.Parse(Console.ReadLine()!);

            Product product = new(productName, productPrice);

            OrderItem items = new(quantity, productPrice, product);

            order.AddItem(items);
        }

        Console.WriteLine("ORDER SUMMARY:");
        Console.WriteLine(order);
    }
}
