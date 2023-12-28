namespace CourseWork.Entities;

public class Sushi
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Count { get; set; }
    public Sushi(string name, int count)
    {
        Name = name;
        Count = count;
    }
}
