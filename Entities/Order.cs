namespace LearningCSharp.Entities;

internal class Order
{
    public int Id { get; set; }

    public DateTime OrderTime { get; set; }

    public OrderStatus Status { get; set; }


    public override string ToString()
    {
        return $"Order id: {Id}\n" +
            $"Order time: {OrderTime}\n" +
            $"Status: {Status}";
    }
}
