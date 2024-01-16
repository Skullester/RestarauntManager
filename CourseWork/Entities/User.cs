using Extentions;

namespace CourseWork.Entities;

public class User
{
    public int Id { get; set; }
    public List<Order>? Orders { get; set; } = new();
    public string Name { get; set; }
    public int CountOrders { get; set; }
    private string number = null!;
    public string Number
    {
        get => "+" + number;
        set
        {
            var isNotValid = value
                .Any(x => !x.IsDigit());
            if (value.Length != 11 || isNotValid)
                throw new ArgumentException("Некорретно введенный номер!");
            number = value;
        }
    }
    public User(string number, string name)
    {
        Name = name;
        Number = number;
    }

    public override string ToString() => Name;
}
