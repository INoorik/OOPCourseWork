using CourseWork.Contexts;
using CourseWork.Entities;
using Microsoft.EntityFrameworkCore;

namespace CourseWork.Services;

/// <summary>
/// Сервис для выполнения операций с самолетом в базе данных.
/// </summary>
public class PlaneService
{
    private readonly AirportContext _dbContext;

    /// <summary>
    /// Инициализирует новый экземпляр класса PlaneService.
    /// </summary>
    /// <param name="dbContext">Контекст базы данных.</param>
    public PlaneService(AirportContext dbContext) => _dbContext = dbContext;

    /// <summary>
    /// Возвращает список всех самолетов в базе данных.
    /// </summary>
    /// <returns>Список всех самолетов в базе данных.</returns>
    public async Task<List<Plane>> GetAllPlanesAsync() => await _dbContext.Planes.ToListAsync();

    /// <summary>
    /// Возвращает самолет по его идентификатору.
    /// </summary>
    /// <param name="id">Идентификатор самолета.</param>
    /// <returns>Самолет с указанным идентификатором.</returns>
    public async Task<Plane?> GetPlaneByIdAsync(int id) => await _dbContext.Planes.FindAsync(id);

    /// <summary>
    /// Добавляет новый самолет в базу данных.
    /// </summary>
    /// <param name="plane">Новый самолет.</param>
    /// <returns>Асинхронная задача.</returns>
    public async Task AddPlaneAsync(Plane plane)
    {
        _dbContext.Planes.Add(plane);
        await _dbContext.SaveChangesAsync();
    }

    /// <summary>
    /// Обновляет существующий самолет в базе данных.
    /// </summary>
    /// <param name="plane">Самолет для обновления.</param>
    /// <returns>Асинхронная задача.</returns>
    public async Task UpdatePlaneAsync(Plane plane)
    {
        _dbContext.Update(plane);
        await _dbContext.SaveChangesAsync();
    }

    /// <summary>
    /// Удаляет самолет из базы данных по его идентификатору.
    /// </summary>
    /// <param name="id">Идентификатор самолета.</param>
    /// <returns>Асинхронная задача.</returns>
    public async Task DeletePlaneAsync(int id)
    {
        var plane = await GetPlaneByIdAsync(id);
        if (plane != null)
        {
            _dbContext.Planes.Remove(plane);
            await _dbContext.SaveChangesAsync();
        }
    }
}
