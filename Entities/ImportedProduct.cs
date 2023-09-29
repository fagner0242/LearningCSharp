﻿using System.Globalization;

namespace LearningCSharp.Entities;

internal class ImportedProduct : Product
{
    public double CustomsFee { get; set; }

    public ImportedProduct() {}

    public ImportedProduct(string? name, double price, double customsFee) : base(name, price)
    {
        CustomsFee = customsFee;
    }

    public double TotalPrice()
    {
        return Price + CustomsFee;
    }

    public override string ToString()
    {
        return $"{Name} $ {TotalPrice().ToString("F2", CultureInfo.InvariantCulture)} (CustomsFee: $ {CustomsFee.ToString("F2", CultureInfo.InvariantCulture)})";
    }
}
