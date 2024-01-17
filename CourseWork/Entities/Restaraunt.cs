using CourseWork;
using ManagerApp;

namespace CourseWork.Entities;

public class Restaraunt
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Profit { get; set; }
    public int OrderCount { get; set; }
    public List<Order> Orders { get; set; }
    public int ClientCount { get; set; }
    public Restaraunt(string name)
    {
        Name = name;
    }
    public override string ToString()
    {
        return Name;
    }

}
