using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.VisualBasic.ApplicationServices;
using System.Reflection.Emit;

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

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Airport>(AirportConfigure);
        modelBuilder.Entity<Airplane>(AirplaneConfigure);
        modelBuilder.Entity<Destination>(DestinationConfigure);
        modelBuilder.Entity<Position>(PositionConfigure);
        //modelBuilder.Entity<Destination>().HasData(new Destination());

        //modelBuilder.Entity<User>().ToTable(t => t.HasCheckConstraint("ValidNumber", "LENGTH(Number) == 11"));
        //modelBuilder.Entity<Order>().Property(x => x.Date).HasDefaultValueSql("datetime('now','localtime')");
    }
    private void PositionConfigure(EntityTypeBuilder<Position> builder)
    {
        var airplanes = new List<Position>
        {
            new Position("Пилот")
            {id = 1 },
            new Position("Бортпроводник")
            {id = 2},
            new Position("Авиадиспетчер")
            {id = 3 },
            new Position ("Борт-инженер")
            {id = 4 },
        };
        builder.HasData(airplanes);
    }
    private void AirplaneConfigure(EntityTypeBuilder<Airplane> builder)
    {
        var airplanes = new List<Airplane>
        {
            new Airplane("Boeing 777",1, true)
            {id = 1 },
            new Airplane("МС-21",2, true)
            {id = 2},
            new Airplane("Sukhoi Superjet 100",3,false)
            {id = 3 },
            new Airplane("Ан-124",2,true)
            {id = 4 },

        };
        builder.HasData(airplanes);
    }
    private void DestinationConfigure(EntityTypeBuilder<Destination> builder)
    {
        var destinations = new List<Destination>
        {
            new Destination(2,1,4,9,DateTime.Now + TimeSpan.FromSeconds(60)) {id = 1},
            new Destination(1,1,4,9,DateTime.Now + TimeSpan.FromHours(4)) {id = 2},
            new Destination(2,1,4,9,DateTime.Now + TimeSpan.FromHours(6)) {id = 3},
            new Destination(4,1,4,9,DateTime.Now + TimeSpan.FromHours(8)) {id = 4},
        };
        builder.HasData(destinations);
    }

    private void AirportConfigure(EntityTypeBuilder<Airport> builder)
    {
        builder.HasAlternateKey(port => port.INN);
        var airports = new Airport[]
        {
            new Airport("Шереметьево", "г.Москва", "1234567890") { id = 1 },
            new Airport("Внуково", "г.Москва", "1234567892") { id = 2 },
            new Airport("Домодедово", "г.Москва", "1224567891") { id = 3 },
            new Airport("АэропортТокио", "г.Токио", "1214567891") { id = 4 },
            new Airport("АэропортКанберра", "г.Канберра", "1334567891") { id = 5 },
            new Airport("АэропортАнкара", "г.Анкара", "1434567891") { id = 6 },
            new Airport("АэропортФранция", "г.Вашингтон", "1534567891") { id = 7 }
        };
        builder.HasData(airports);
    }
}

