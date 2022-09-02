using System.ComponentModel.DataAnnotations;

namespace Acceso_BD.Repository.Entity;

public class Region
{
    [Key] public int? Id { get; set; }
    public string? Nombre { get; set; }
    public virtual ICollection<Pokedex>? Pokedex { get; set; }
}