namespace LearningCSharp;

enum OrderStatus : int
{ 
    pendingPayment,
    processing = 1,
    shipped = 2,
    delivered = 3
}
