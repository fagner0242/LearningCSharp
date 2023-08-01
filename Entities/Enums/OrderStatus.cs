using System;

namespace LearningCSharp.Entities.Enums;

internal enum OrderStatus : int
{
    PendingPayment,
    Processing = 1,
    Shipped = 2,
    Delivered = 3
}
