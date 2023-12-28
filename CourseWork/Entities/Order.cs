namespace CourseWork.Entities;

public class Order
{
    //[Key]
    public int Id { get; set; }
    public DateTime Date { get; set; }
    public virtual Consumer Consumer { get; set; } = null!;
    public string ConsumerNumber => Consumer.Number;
    public int ConsumerId { get; set; }
    public string ProductName { get; set; } = null!;
    public decimal Cost { get; set; }

    public Order(Consumer consumer, string nameProduct, decimal cost)
    {
        Cost = cost;
        ProductName = nameProduct;
        Consumer = consumer;
        Date = DateTime.Now;
    }
    public Order()
    {

    }
}
