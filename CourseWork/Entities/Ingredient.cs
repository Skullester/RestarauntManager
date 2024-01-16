namespace CourseWork.Entities;

public class Ingredient
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Count { get; set; }
    public Ingredient(string name, int count)
    {
        Name = name;
        Count = count;
    }
}
