namespace CourseWork.Entities;

public class Delivery
{
    public int Id { get; set; }
    public Order Order { get; set; }
    public DateTime Time { get; set; }
    public string Comment { get; set; }
    public Status Status { get; set; }
}
public enum Status
{
    Cooking, Delivering, Delivered
}
