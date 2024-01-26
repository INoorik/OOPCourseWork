using CourseWork.Entities;
using Microsoft.EntityFrameworkCore;

namespace CourseWork.Contexts;

/// <summary>
/// Контекст базы данных для приложения автопарк.
/// </summary>
public class AirportContext : DbContext
{
    /// <summary>
    /// Коллекция объектов самолетов в базе данных.
    /// </summary>
    public DbSet<Plane> Planes { get; set; }

    /// <summary>
    /// Коллекция объектов пилотов в базе данных.
    /// </summary>
    public DbSet<Pilot> Pilots { get; set; }

    /// <summary>
    /// Коллекция объектов рейсов в базе данных.
    /// </summary>
    public DbSet<Flight> Flights { get; set; }

    /// <summary>
    /// Путь к файлу базы данных.
    /// </summary>
    public string DbPath { get; }

    /// <summary>
    /// Инициализирует новый экземпляр класса AirportContext.
    /// </summary>
    public AirportContext()
    {
        var folder = Environment.SpecialFolder.LocalApplicationData;
        var path = Environment.GetFolderPath(folder);
        DbPath = Path.Join(path, "airport.db");
    }

    /// <summary>
    /// Настраивает параметры подключения к базе данных.
    /// </summary>
    /// <param name="optionsBuilder">Строитель опций для контекста базы данных.</param>
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlite($"Data Source={DbPath}");

    /// <summary>
    /// Настраивает модель данных для базы данных.
    /// </summary>
    /// <param name="modelBuilder">Строитель модели для контекста базы данных.</param>
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Связь один-ко-многим между Flight и Plane
        modelBuilder.Entity<Flight>()
            .HasMany(r => r.Planes) // каждый Flight может иметь множество связанных сущностей Plane
            .WithOne(t => t.Flight) // каждая сущность Plane может быть связана только с одной сущностью Flight
            .HasForeignKey(t => t.FlightId); // внешний ключ для связи находится в свойстве FlightId в сущности Plane

        // Связь один-к-одному между Plane и Pilot
        modelBuilder.Entity<Plane>()
            .HasOne(t => t.Pilot) // каждая сущность Plane может быть связана только с одной сущностью Pilot
            .WithOne(d => d.Plane) // каждая сущность Pilot может быть связана только с одной сущностью Plane
            .HasForeignKey<Pilot>(d => d.PlaneId); // внешний ключ для связи находится в свойстве PlaneId в сущности Pilot
    }
}