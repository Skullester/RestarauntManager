
namespace CourseWork.Entities;

public class Category
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<Product> Products { get; set; }
    public Category(string name)
    {
        Name = name;
    }
    public override string ToString()
    {
        return Name;
    }
}
