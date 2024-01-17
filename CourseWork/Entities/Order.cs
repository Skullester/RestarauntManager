using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CourseWork.Entities;

public class Order
{
    //[Key]
    //[NotMapped]
    [Key]
    public int Id { get; set; }
    public DateTime Date { get; set; }
    public User User { get; set; } = null!;
    public string UserNumber => User.Number;
    public int UserId { get; set; }
    public string ProductName { get; set; } = null!;
    public int Cost { get; set; }
    public Restaraunt Restaraunt { get; set; }
    public int RestarauntId { get; set; }

    public Order(int restarauntId, int userId, string nameProduct, int cost)
    {
        RestarauntId = restarauntId;
        UserId = userId;
        Cost = cost;
        ProductName = nameProduct;
        //Date = DateTime.Now;
    }
    public Order()
    {

    }
}
