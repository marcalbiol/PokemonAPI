namespace PokemonBackend.Models
{
    public class Entrenadores_Pokemon
    {

        public int? EntrenadorId{ get; set; }
        public Entrenador? Entrenador{ get; set; }
        public int? PokemonId { get; set; }
        public Pokemon? Pokemon{ get; set; }
    }
}
