using CourseWork.Contexts;
using CourseWork.Entities;
using Microsoft.EntityFrameworkCore;

namespace CourseWork.Services;

/// <summary>
/// Сервис для выполнения операций с пилотом в базе данных.
/// </summary>
public class PilotService
{
    private readonly AirportContext _dbContext = new();

    /// <summary>
    /// Инициализирует новый экземпляр класса PilotService.
    /// </summary>
    /// <param name="dbContext">Контекст базы данных.</param>
    public PilotService(AirportContext dbContext) => _dbContext = dbContext;

    /// <summary>
    /// Возвращает список всех пилотов в базе данных.
    /// </summary>
    /// <returns>Список всех пилотов в базе данных.</returns>
    public async Task<List<Pilot>> GetAllPilotsAsync() => await _dbContext.Pilots.ToListAsync();

    /// <summary>
    /// Возвращает пилота по его идентификатору.
    /// </summary>
    /// <param name="id">Идентификатор пилота.</param>
    /// <returns>Пилот с указанным идентификатором.</returns>
    public async Task<Pilot?> GetPilotsByIdAsync(int id) => await _dbContext.Pilots.FindAsync(id);

    /// <summary>
    /// Добавляет нового пилота в базу данных.
    /// </summary>
    /// <param name="pilot">Новый пилот.</param>
    /// <returns>Асинхронная задача.</returns>
    public async Task AddPilotAsync(Pilot pilot)
    {
        _dbContext.Pilots.Add(pilot);
        await _dbContext.SaveChangesAsync();
    }

    /// <summary>
    /// Обновляет существующего пилота в базе данных.
    /// </summary>
    /// <param name="pilot">Пилот для обновления.</param>
    /// <returns>Асинхронная задача.</returns>
    public async Task UpdatePilotAsync(Pilot pilot)
    {
        _dbContext.Update(pilot);
        await _dbContext.SaveChangesAsync();
    }

    /// <summary>
    /// Удаляет пилота из базы данных по его идентификатору.
    /// </summary>
    /// <param name="id">Идентификатор пилота.</param>
    /// <returns>Асинхронная задача.</returns>
    public async Task DeletePilotAsync(int id)
    {
        var driver = await GetPilotsByIdAsync(id);
        if (driver != null)
        {
            _dbContext.Pilots.Remove(driver);
            await _dbContext.SaveChangesAsync();
        }
    }
}
