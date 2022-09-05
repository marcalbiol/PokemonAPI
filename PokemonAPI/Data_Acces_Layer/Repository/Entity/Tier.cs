namespace Acceso_BD.Repository.Entity;

public class Tier
{
    public int Id { get; set; }
    public string? Descripcion { get; set; }
    public virtual Pokedex? Pokedex { get; set; }
}