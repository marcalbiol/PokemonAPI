using System.ComponentModel.DataAnnotations;
using PokemonBackend.Models;

namespace Acceso_BD.Repository.Entity;

public class Pokedex
{
    [Key] public int? ID { get; set; }

    public string? Nombre { get; set; }
    public string? Imagen { get; set; }

    public string? Altura { get; set; }
    public string? Peso { get; set; }
    public virtual ICollection<Pokemon>? Pokemons { get; set; }

    public int? TierId { get; set; }
    public virtual Tier? Tier { get; set; }

    public bool? Basico { get; set; }

    public virtual List<Tipo>? Tipos { get; set; }
    public virtual List<PokedexTipo>? PokedexTipos { get; set; }


    public int? RegionId { get; set; }
    public virtual Region? Region { get; set; }
    public int? ZonaId { get; set; }
    public virtual Zona? Zona { get; set; }
}