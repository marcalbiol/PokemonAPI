using Acceso_BD.Repository.Entity;

namespace PokemonBackend.Models
{
    public class Tipos_Pokemons
    {

      public int TipoId { get; set; }   
      public Tipo? Tipo { get; set; }

      public int? PokedexId { get; set; }
      public Pokedex? Pokedex { get; set; }
        

    }
}
