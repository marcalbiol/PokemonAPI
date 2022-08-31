namespace Acceso_BD.Repository.Entity
{
    public class Zona
    {
        public int? Id { get; set; }
        public string? NombreZona { get; set; }
        public virtual ICollection<Pokedex>? PokeZona { get; set; }
    }
}
