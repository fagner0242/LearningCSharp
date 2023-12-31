﻿using LearningCSharp.Entities;
using System.Collections.Generic;
using System.Globalization;

Console.Write("Enter the number of products: ");
int numberOfProducts = int.Parse(Console.ReadLine()!);

List<Product> products = new();

for (int i = 1; i <= numberOfProducts; i++)
{
    Console.WriteLine($"Product #{i} data:");

    Console.Write("Common, used or imported (c/u/i)? ");
    char commonUsedImported = char.Parse(Console.ReadLine()!);

    Console.Write("Name: ");
    string name = Console.ReadLine()!;

    Console.Write("Price: ");
    double price = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

    if (commonUsedImported == 'c')
        products.Add(new Product(name, price));
    else if (commonUsedImported == 'u')
    {
        Console.Write("Manufacture date (DD/MM/YYYY): ");
        DateTime manufactureDate = DateTime.Parse(Console.ReadLine()!);
        products.Add(new UsedProduct(name, price, manufactureDate));
    }
    else if (commonUsedImported == 'i')
    {
        Console.Write("Customs fee: ");
        double customFee = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
        products.Add(new ImportedProduct(name, price, customFee));
    }

}

Console.WriteLine();
Console.WriteLine("PRICE TAGS:");

foreach (Product product in products)
{
    Console.WriteLine(product);
}