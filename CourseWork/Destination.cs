using System.ComponentModel.DataAnnotations;

namespace Airport;

public class Destination
{
    [Key]
    public int id { get; set; }
    public Airport start_airport { get; set; }
    public Airport end_airport { get; set; }
    public byte flight_hours { get; set; }
    public Airplane airplane { get; set; }

}
