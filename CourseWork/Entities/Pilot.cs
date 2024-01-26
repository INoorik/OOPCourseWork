using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CourseWork.Entities;

/// <summary>
/// Представляет пилота в системе управления аэропортом.
/// </summary>
[Table("Pilots")]
public class Pilot
{
    /// <summary>
    /// Уникальный идентификатор пилота.
    /// </summary>
    [Key]
    [DisplayName("ID")]
    public int Id { get; set; }

    /// <summary>
    /// Имя пилота.
    /// </summary>
    [Required]
    [MaxLength(50)]
    [DisplayName("Имя")]
    public string? FirstName { get; set; }

    /// <summary>
    /// Фамилия пилота.
    /// </summary>
    [Required]
    [MaxLength(50)]
    [DisplayName("Фамилия")]
    public string? LastName { get; set; }

    /// <summary>
    /// Возраст пилота.
    /// </summary>
    [Required]
    [DisplayName("Возраст")]
    public int Age { get; set; }

    /// <summary>
    /// Стаж работы пилота в годах.
    /// </summary>
    [Required]
    [Range(0, int.MaxValue)]
    [DisplayName("Стаж")]
    public int FlyingExperience { get; set; }

    /// <summary>
    /// Внешний ключ, связывающий пилота с самолетом.
    /// </summary>
    [DisplayName("ID самолета")]
    public int? PlaneId { get; set; }

    /// <summary>
    /// Навигационное свойство, которое позволяет получить объект самолета, связанный с данным пилотом.
    /// </summary>
    [DisplayName("Самолет")]
    public Plane? Plane { get; set; }

    /// <summary>
    /// Внешний ключ, связывающий пилота с рейсом.
    /// </summary>
    [DisplayName("ID Рейса")]
    public int? FlightID { get; set; }

    /// <summary>
    /// Коллекция рейсов, которые может обслуживать данный пилот.
    /// </summary>
    [DisplayName("Рейс")]
    public Flight? Flight { get; set; }

    /// <summary>
    /// Возвращает строковое представление объекта пилота, содержащее его идентификатор, имя, фамилию, возраст и стаж.
    /// </summary>
    /// <returns>Строковое представление объекта пилота.</returns>
    public override string ToString()
        => $"{FirstName} {LastName}, возраст: {Age}, стаж: {FlyingExperience}";
}