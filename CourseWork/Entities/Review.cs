namespace CourseWork.Entities;

public class Review
{
    public int Id { get; set; }
    public Order Order { get; set; }
    public User User { get; set; }
}
