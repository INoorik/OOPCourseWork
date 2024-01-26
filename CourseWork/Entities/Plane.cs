using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CourseWork.Entities;

/// <summary>
/// Представляет самолет.
/// </summary>
[Table("Planes")]
public class Plane
{
    /// <summary>
    /// Уникальный идентификатор самолета.
    /// </summary>
    [Key]
    [DisplayName("ID")]
    public int Id { get; set; }

    /// <summary>
    /// Модель самолета.
    /// </summary>
    [Required]
    [MaxLength(50)]
    [DisplayName("Модель")]
    public string Model { get; set; } = string.Empty;

    /// <summary>
    /// Государственный регистрационный номер воздушного судна.
    /// </summary>
    [Required]
    [MaxLength(6)]
    [DisplayName("Номерной знак")]
    public string LicensePlate { get; set; } = string.Empty;

    /// <summary>
    /// Вместимость самалета.
    /// </summary>
    [Required]
    [Range(2, int.MaxValue)]
    [DisplayName("Кол-во мест")]
    public int Capacity { get; set; }

    /// <summary>
    /// Дата последнего технического обслуживания самолета.
    /// </summary>
    [Required]
    [DisplayName("Дата тех. обслуживания")]
    public DateTime LastMaintenanceDate { get; set; }

    /// <summary>
    ///  Текущее количество летных часов самолета
    /// </summary>
    [Required]
    [Range(0, double.MaxValue)]
    [DisplayName("Летные часы")]
    public double FlightTime { get; set; }

    /// <summary>
    /// Идентификатор рейса, на котором работает самолет.
    /// </summary>
    [DisplayName("ID Рейса")]
    public int? FlightId { get; set; }

    /// <summary>
    /// Рейс, на котором работает самолет.
    /// </summary>
    [DisplayName("Рейс")]
    public Flight? Flight { get; set; }

    /// <summary>
    /// Идентификатор пилота, который управляет самолетом.
    /// </summary>
    [DisplayName("ID Водителя")]
    public int? PilotId { get; set; }

    /// <summary>
    /// Пилот, который управляет самолетом.
    /// </summary>
    [DisplayName("Пилот")]
    public Pilot? Pilot { get; set; }

    /// <summary>
    /// Возвращает строковое представление объекта самолета, содержащее его идентификатор, модель, государственный регистрационный номер и вместимость.
    /// </summary>
    /// <returns>Строковое представление объекта транспортного средства.</returns>
    public override string ToString()
        => $"Бренд: {Model}, Номер. знак: {LicensePlate}, Вместимость: {Capacity}";
}
