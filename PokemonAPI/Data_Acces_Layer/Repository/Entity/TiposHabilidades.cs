using PokemonBackend.Models;

namespace Acceso_BD.Repository.Entity;

public class Tipos_Habilidades
{
    public int Id { get; set; }
    public int? HabilidadId { get; set; }
    public virtual Habilidades? Habilidades { get; set; }
    public int? TipoId { get; set; }
    public virtual Tipo? Tipo { get; set; }
}