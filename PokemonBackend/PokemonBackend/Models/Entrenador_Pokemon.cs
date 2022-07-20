namespace PokemonBackend.Models
{
    public class Entrenador_Pokemon
    {

        public int EntrenadorId{ get; set; }
        public Entrenador? Entrenador{ get; set; }
        public int PokemonId { get; set; }
        public Pokemon? Pokemon{ get; set; }
    }
}
