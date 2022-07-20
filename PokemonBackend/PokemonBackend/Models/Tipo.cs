namespace PokemonBackend.Models
{
    public class Tipo
    {
        public int Id { get; set; }
        public string? Tipo_pokemon { get; set; }
        public string? Ventaja { get; set; }
        public string? Desventaja { get; set; }

        public ICollection<Tipo_Pokemons>? Tipos { get; set; }

    }
}
