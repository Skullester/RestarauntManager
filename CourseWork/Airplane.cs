using System.ComponentModel.DataAnnotations;

namespace Airport;

public class Airplane
{
    [Key]
    public int id { get; set; }
    public Airport airport { get; set; }
    public string name { get; set; }
    public List<Destination> destination { get; set; }
}
