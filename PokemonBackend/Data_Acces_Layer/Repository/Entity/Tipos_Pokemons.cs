using Acceso_BD.Repository.Entity;
using System.ComponentModel.DataAnnotations;

namespace PokemonBackend.Models
{
    public class Tipos_Pokemons
    {

      [Key]  
      public int Id { get; set; }
      public int TipoId { get; set; }   
      public Tipo? Tipo { get; set; }

      public int? PokedexId { get; set; }
      public Pokedex? Pokedex { get; set; }
        

    }
}
