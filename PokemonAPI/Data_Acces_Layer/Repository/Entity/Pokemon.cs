using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Acceso_BD.Repository.Entity;

namespace PokemonBackend.Models;

public class Pokemon
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Key]
    public int? Id { get; set; }

    public string? Nombre { get; set; }
    public bool? Shiny { get; set; }
    public int Nivel { get; set; }
    public int? PokedexId { get; set; }

    public virtual Pokedex? Pokedex { get; set; }

    /*
    public Boolean? BasicoId { get; set; }
    public Pokedex Basico { get; set; }
    public int? TierId { get; set; }
    public Pokedex Tier { get; set; }
     */
    public int? StatId { get; set; }
    public virtual Stat? Stat { get; set; }
    public virtual ICollection<Entrenadores_Pokemon>? Entrenador_Pokemons { get; set; }
}