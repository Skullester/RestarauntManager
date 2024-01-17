using Microsoft.EntityFrameworkCore;

namespace Airport;
public class Context : DbContext
{
    public Context()
    {
        Database.EnsureDeleted();
        Database.EnsureCreated();
    }
    public DbSet<Order> Orders { get; set; }
    public DbSet<Ingredient> Ingredients { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Product> Menu { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Restaraunt> Restarauntss { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite(@"Data Source=..\..\..\..\CourseWork\bin\Debug\net8.0-windows\newDB.db");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>().HasData(user1, user2, user3);
        modelBuilder.Entity<User>().HasAlternateKey(user => user.Number);
        modelBuilder.Entity<User>().ToTable(t => t.HasCheckConstraint("ValidNumber", "LENGTH(Number) == 11"));
        modelBuilder.Entity<Order>().Property(x => x.Date).HasDefaultValueSql("datetime('now','localtime')");
    }
}
