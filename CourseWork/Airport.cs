using System.ComponentModel.DataAnnotations;

namespace Airport;

public class Airport
{
    [Key]
    public int id { get; set; }
    public string name { get; set; }
    public string address { get; set; }
    public List<Airplane> airplanes { get; set; }
    public string INN { get; set; }
}
