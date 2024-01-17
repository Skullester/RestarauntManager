using Microsoft.EntityFrameworkCore;
using CourseWork.Entities;
using System.Xml;

namespace CourseWork;
public class ApplicationContext : DbContext
{
    public ApplicationContext()
    {
        // Database.EnsureDeleted();
        Database.EnsureCreated();
    }
    public DbSet<Order> Orders { get; set; }
    public DbSet<Ingredient> Products { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Product> Menu { get; set; }
    public DbSet<Review> Reviews { get; set; }
    public DbSet<Delivery> Deliveries { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite(@"Data Source=..\..\..\..\CourseWork\bin\Debug\net8.0-windows\helloapp2.db");
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        var user1 = new User("12345678901", "Aleksey") { Id = 1 };
        var user2 = new User("12345678921", "Sasha") { Id = 2 };
        user1.CountOrders++;
        user2.CountOrders++;
        var order1 = new Order(user1.Id, "Гункан", 200) { Id = 1 };
        var order2 = new Order(user2.Id, "Филадельфия", 500) { Id = 3 };
        var order3 = new Order(2, "Элитный ролл", 10000) { Id = 2 };

        modelBuilder.Entity<User>().HasData(user1, user2);
        modelBuilder.Entity<Order>().HasData(order1, order2, order3);
        modelBuilder.Entity<User>().HasAlternateKey(user => user.Number);
        modelBuilder.Entity<Ingredient>().HasData(new Ingredient("Сливочный сыр", 100) { Id = 1 });
        modelBuilder.Entity<Ingredient>().HasData(new Ingredient("Лосось", 20) { Id = 2 });
        modelBuilder.Entity<User>().ToTable(t => t.HasCheckConstraint("ValidNumber", "LENGTH(Number) == 11"));
        modelBuilder.Entity<Order>().Property(x => x.Date).HasDefaultValueSql("datetime('now','localtime')");
        var products = new Product[]
        {
            new("Запеченная Калифорния",300) {Id = 1},
            new("Запеченный унаги",300) {Id =2 },
            new("Чикен биг хот",300) {Id =3 },
            new("Хайнань",300){ Id = 4},

            new("Ролл с морским окунем",200) {Id = 5},
            new("Ролл с креветкой спайси",200) {Id =6},
            new("Ролл с курицей и огурцом",200) {Id = 7},
            new("Ролл с авокадо",200){Id = 8},

            new("Аруба Люкс",400) { Id = 9},
            new("Пафос Люкс",400) {Id=10},
            new("Манхэттен Люкс",400){Id =11},
            new("Калифорния Люкс",400){Id=12},

            new("Гункан с тунцом и филадельфией",500){Id =13},
            new("Гункан с тунцом спайси",500){Id=14},
            new("Гункан с морским окунем и филадельфией",500){Id=15},
            new("Суши с лососем",500){Id=16},
        };
        modelBuilder.Entity<Product>().HasData(products);
    }
}
