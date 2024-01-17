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
    public static List<Product> Products { get; }
    public static List<Restaraunt> Restaraunts { get; }
    static ApplicationContext()
    {
        Products = new List<Product>
        {
            new(1,"Запеченная Калифорния",300) {Id = 1},
            new(1,"Запеченный унаги",300) {Id =2},
            new(1,"Чикен биг хот",300) {Id =3},
            new(1,"Хайнань",300){ Id = 4},

            new(2,"Ролл с морским окунем",200) {Id = 5},
            new(2,"Ролл с креветкой спайси",200) {Id =6},
            new(2,"Ролл с курицей и огурцом",200) {Id = 7},
            new(2,"Ролл с авокадо",200){Id = 8},

            new(3,"Аруба Люкс",400) { Id = 9},
            new(3,"Пафос Люкс",400) {Id=10},
            new(3,"Манхэттен Люкс",400){Id =11},
            new(3,"Калифорния Люкс",400){Id=12},

            new(4,"Гункан с тунцом и филадельфией",500){Id =13},
            new(4,"Гункан с тунцом спайси",500){Id=14},
            new(4,"Гункан с морским окунем и филадельфией",500){Id=15},
            new(4,"Суши с лососем",500){Id=16},
        };
        Restaraunts = new()
        {
            new Restaraunt("Ворошилова") { Id = 1 },
            new Restaraunt("50 лет ВЛКСМ") { Id = 2 },
        };

    }
    public DbSet<Order> Orders { get; set; }
    public DbSet<Ingredient> Ingredients { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Product> Menu { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Restaraunt> Restarauntss { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite(@"Data Source=..\..\..\..\CourseWork\bin\Debug\net8.0-windows\helloapp2.db");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        var user1 = new User("12345678901", "Алексей") { Id = 1, CountOrders = 1 };
        var user2 = new User("12345678921", "Александр") { Id = 2, CountOrders = 1 };
        var user3 = new User("12345678923", "Сергей") { Id = 3, CountOrders = 1 };
        var order1 = new Order(Restaraunts[0].Id, user1.Id, "Гункан", 200) { Id = 1 };
        var order2 = new Order(Restaraunts[1].Id, user2.Id, "Филадельфия", 500) { Id = 2 };
        var order3 = new Order(Restaraunts[1].Id, user3.Id, "Элитный ролл", 10000) { Id = 3 };

        modelBuilder.Entity<User>().HasData(user1, user2, user3);
        modelBuilder.Entity<Order>().HasData(order1, order2, order3);
        modelBuilder.Entity<User>().HasAlternateKey(user => user.Number);
        modelBuilder.Entity<Ingredient>().HasData(new Ingredient("Сливочный сыр", 100) { Id = 1 });
        modelBuilder.Entity<Ingredient>().HasData(new Ingredient("Лосось", 20) { Id = 2 });
        modelBuilder.Entity<Ingredient>().HasData(new Ingredient("Курица", 10) { Id = 3 });
        modelBuilder.Entity<Ingredient>().HasData(new Ingredient("Бекон", 25) { Id = 4 });
        modelBuilder.Entity<Ingredient>().HasData(new Ingredient("Окунь", 25) { Id = 5 });
        modelBuilder.Entity<Ingredient>().HasData(new Ingredient("Огурец", 250) { Id = 6 });
        modelBuilder.Entity<Ingredient>().HasData(new Ingredient("Лук", 100) { Id = 7 });
        modelBuilder.Entity<Ingredient>().HasData(new Ingredient("Крабовые палочки", 40) { Id = 8 });
        modelBuilder.Entity<User>().ToTable(t => t.HasCheckConstraint("ValidNumber", "LENGTH(Number) == 11"));
        modelBuilder.Entity<Order>().Property(x => x.Date).HasDefaultValueSql("datetime('now','localtime')");
        modelBuilder.Entity<Restaraunt>().HasData(Restaraunts);
        var categories = new List<Category>
        {
            new Category("Горячие") { Id = 1 },
            new Category("Классические") { Id = 2 },
            new Category("Люкс") { Id = 3 },
            new Category("Суши и гунканы") { Id = 4 },
        };
        modelBuilder.Entity<Category>().HasData(categories);
        modelBuilder.Entity<Product>().HasData(Products);
    }
}
