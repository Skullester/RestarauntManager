namespace CourseWork.Entities;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<Ingredient> Ingredients { get; set; }
    public int OrderCount { get; set; }
    public int Cost { get; set; }
    public Product(string name, int cost)
    {
        Name = name;
        Cost = cost;
    }
}
