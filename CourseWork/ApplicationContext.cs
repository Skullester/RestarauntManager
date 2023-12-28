using Microsoft.EntityFrameworkCore;
using CourseWork.Entities;

namespace CourseWork;
public class ApplicationContext : DbContext
{
    public ApplicationContext()
    {
        // Database.EnsureDeleted();
        Database.EnsureCreated();
    }
    public DbSet<Order> Orders { get; set; }
    public DbSet<Sushi> Products { get; set; }
    public DbSet<Consumer> Users { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite(@"Data Source=..\..\..\..\CourseWork\bin\Debug\net8.0-windows\helloapp.db");
    }
}
