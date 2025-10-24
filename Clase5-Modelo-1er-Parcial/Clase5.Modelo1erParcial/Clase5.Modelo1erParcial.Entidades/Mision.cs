using System.ComponentModel.DataAnnotations;

namespace Clase5.Modelo1erParcial.Entidades;

public class Mision
{
    /// <summary>
    /// Id de la Misión
    /// </summary>
    public int IdMision { get; set; }

    /// <summary>
    /// Nombre del Superhéroe
    /// </summary>
    [StringLength(40)]
    [Required]
    public string NombreSuperheroe { get; set; }

    /// <summary>
    /// Cantidad de Villanos Derrotados
    /// </summary>
    [Range(1, 499)]
    [Required]
    public int CantVillanosDerrotados { get; set; }

    /// <summary>
    /// Horas de Misión
    /// </summary>    
    [Range(1, 71)]
    [Required]
    public int HorasMision { get; set; }

    /// <summary>
    /// Índice de Eficiencia = (Cantidad de Villanos Derrotados * 100) / Horas de Misión
    /// </summary>
    
    public double IndiceEficiencia { get; set; }
}
