namespace CourseWork.Entities;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<Ingredient> Ingredients { get; set; }
    public int OrderCount { get; set; }
    public int Cost { get; set; }
    public Category Category { get; set; } = null!;

    public int CategoryId { get; set; }
    public Product(int categoryId, string name, int cost)
    {
        CategoryId = categoryId;
        Name = name;
        Cost = cost;
    }
    public Product()
    {

    }
}
