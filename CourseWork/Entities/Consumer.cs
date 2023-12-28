using Extentions;

namespace CourseWork.Entities;

public class Consumer
{
    public int Id { get; set; }
    public List<Order>? Orders { get; set; }
    public string Name { get; set; }
    public int CountOrders { get; set; } = 1;
    private string number = null!;
    public string Number
    {
        get => "+" + number;
        set
        {
            var isNotDigit = value
                .Any(x => !x.IsDigit());
            if (value.Length != 11 || isNotDigit)
                throw new ArgumentException("Некорретно введенный номер!");
            number = value;
        }
    }
    public Consumer(string number, string name)
    {
        Name = name;
        Number = number;
    }
    public override string ToString()
    {
        return Name;
    }
}
