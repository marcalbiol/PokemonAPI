using System.ComponentModel.DataAnnotations;
using Acceso_BD.Repository.Entity;

namespace PokemonBackend.Models;

public class PokedexTipo
{
    [Key] public int Id { get; set; }
    public int TipoId { get; set; }
    public virtual Tipo? Tipo { get; set; }
    public int? PokedexId { get; set; }
    public virtual Pokedex? Pokedex { get; set; }
}