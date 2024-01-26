using CourseWork.Contexts;
using CourseWork.Entities;
using Microsoft.EntityFrameworkCore;

namespace CourseWork.Services;

/// <summary>
/// Сервис для выполнения операций с рейсами в базе данных.
/// </summary>
public class FlightService
{
    private readonly AirportContext _dbContext;

    /// <summary>
    /// Инициализирует новый экземпляр класса RouteService.
    /// </summary>
    /// <param name="dbContext">Контекст базы данных.</param>
    public FlightService(AirportContext dbContext) => _dbContext = dbContext;

    /// <summary>
    /// Возвращает список всех рейсов в базе данных.
    /// </summary>
    /// <returns>Список всех рейсов в базе данных.</returns>
    public async Task<List<Flight>> GetAllFlightsAsync() => await _dbContext.Flights.ToListAsync();

    /// <summary>
    /// Возвращает рейс по его идентификатору.
    /// </summary>
    /// <param name="id">Идентификатор рейса.</param>
    /// <returns>Рейс с указанным идентификатором.</returns>
    public async Task<Flight?> GetFlightByIdAsync(int id) => await _dbContext.Flights.FindAsync(id);

    /// <summary>
    /// Добавляет новый рейс в базу данных.
    /// </summary>
    /// <param name="flight">Новый рейс.</param>
    /// <returns>Асинхронная задача.</returns>
    public async Task AddFlightAsync(Flight flight)
    {
        _dbContext.Flights.Add(flight);
        await _dbContext.SaveChangesAsync();
    }

    /// <summary>
    /// Обновляет существующий рейс в базе данных.
    /// </summary>
    /// <param name="flight">Рейс для обновления.</param>
    /// <returns>Асинхронная задача.</returns>
    public async Task UpdateFlightAsync(Flight flight)
    {
        _dbContext.Update(flight);
        await _dbContext.SaveChangesAsync();
    }

    /// <summary>
    /// Удаляет рейс из базы данных по его идентификатору.
    /// </summary>
    /// <param name="id">Идентификатор рейса.</param>
    /// <returns>Асинхронная задача.</returns>
    public async Task DeleteFlightAsync(int id)
    {
        var route = await GetFlightByIdAsync(id);
        if (route != null)
        {
            _dbContext.Flights.Remove(route);
            await _dbContext.SaveChangesAsync();
        }
    }
}