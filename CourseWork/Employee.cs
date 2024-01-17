using System.ComponentModel.DataAnnotations;

namespace Airport;

public class Employee
{
    [Key]
    public int id { get; set; }
    public string INN { get; set; }
    public string fullname { get; set; }
    public Position position { get; set; }

}
