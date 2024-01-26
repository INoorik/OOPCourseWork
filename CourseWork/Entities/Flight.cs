using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CourseWork.Entities;

/// <summary>
/// Представляет рейс в системе управления аэропортом.
/// </summary>
[Table("Flights")]
public class Flight
{
    /// <summary>
    /// Уникальный идентификатор рейса.
    /// </summary>
    [Key]
    [DisplayName("ID")]
    public int Id { get; set; }

    /// <summary>
    /// Название рейса.
    /// </summary>
    [Required]
    [MaxLength(50)]
    [DisplayName("Название")]
    public string? Name { get; set; }

    /// <summary>
    /// Начальная точка рейса.
    /// </summary>
    [Required]
    [MaxLength(255)]
    [DisplayName("Стартовая точка")]
    public string? StartLocation { get; set; }

    /// <summary>
    /// Конечная точка рейса .
    /// </summary>
    [Required]
    [MaxLength(255)]
    [DisplayName("Конечная точка")]
    public string? EndLocation { get; set; }

    /// <summary>
    /// Длина маршрута в километрах.
    /// </summary>
    [Required]
    [Range(0, int.MaxValue)]
    [DisplayName("Длина маршрута")]
    public int Distance { get; set; }

    /// <summary>
    /// Время вылета.
    /// </summary>
    [Required]
    [DisplayName("Время вылета")]
    public DateTime StartTime { get; set; }

    /// <summary>
    /// Время прибытия.
    /// </summary>
    [Required]
    [DisplayName("Время прибытия")]
    public DateTime EndTime { get; set; }

    /// <summary>
    /// Коллекция самолётов, которые могут летать данным рейсом.
    /// </summary>
    [DisplayName("Самолеты")]
    public List<Plane?> Planes { get; set; } = new();

    /// <summary>
    /// Коллекция водителей, которые могут обслуживать данный маршрут.
    /// </summary>
    [DisplayName("Пилоты")]
    public List<Pilot?> Pilots { get; set; } = new();

    /// <summary>
    /// Возвращает строковое представление объекта рейса, содержащее его идентификатор, название, начальное и конечное местоположение, длину, время начала и окончания движения по маршруту.
    /// </summary>
    /// <returns>Строковое представление объекта рейса.</returns>
    public override string ToString()
        => $"Название: {Name}, Нач. точка: {StartLocation}, Конеч. точка: {EndLocation}, Расстояние: {Distance}, Время начала: {StartTime}, Время конца: {EndTime}";
}
