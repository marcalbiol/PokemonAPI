using Acceso_BD.Repository.Entity;
using System.ComponentModel.DataAnnotations;

namespace PokemonBackend.Models
{
    public class Tipos_Pokemons
    {

      [Key]  
      public int Id { get; set; }
      public int TipoId { get; set; }   
      public virtual Tipo? Tipo { get; set; }

      public int? PokedexId { get; set; }
      public virtual Pokedex? Pokedex { get; set; }
        

    }
}
