namespace PokemonBackend.Models
{
    public class Tipos_Pokemons
    {
      public int? PokemonId { get; set; }    
      public Pokemon? Pokemon { get; set; }
      public int TipoId { get; set; }   
      public Tipo? Tipo { get; set; }
        

    }
}
