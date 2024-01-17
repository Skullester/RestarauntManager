using Microsoft.EntityFrameworkCore;

namespace Airport;
public class Context : DbContext
{
    public Context()
    {
        Database.EnsureDeleted();
        Database.EnsureCreated();
    }
    public DbSet<Airport> Airports { get; set; }
    public DbSet<Airplane> Airplanes { get; set; }
    public DbSet<Employee> Personal { get; set; }
    public DbSet<Position> Positions { get; set; }
    public DbSet<Destination> Destinations { get; set; }
    public DbSet<Crew> Crews { get; set; }
    public DbSet<Service> Services { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite(@"Data Source=..\..\..\..\CourseWork\bin\Debug\net8.0-windows\airplane.db");
    }

    //protected override void OnModelCreating(ModelBuilder modelBuilder)
    //{
    //    modelBuilder.Entity<User>().HasData(user1, user2, user3);
    //    modelBuilder.Entity<User>().HasAlternateKey(user => user.Number);
    //    modelBuilder.Entity<User>().ToTable(t => t.HasCheckConstraint("ValidNumber", "LENGTH(Number) == 11"));
    //    modelBuilder.Entity<Order>().Property(x => x.Date).HasDefaultValueSql("datetime('now','localtime')");
    //}
}
