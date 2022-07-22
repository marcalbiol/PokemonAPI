namespace PokemonBackend.Models
{
    public class Tipo
    {
        public int Id { get; set; }
        public string? Tipo_pokemon { get; set; }
        public string? Eficaz { get; set; }
        public string? Debil { get; set; }
        public Habilidades_Agua? Habilidades_Agua { get; set; }
        public Habilidades_Fuego? Habilidades_Fuego { get; set; }

        public ICollection<Tipos_Pokemons>? Tipos { get; set; }

    }
}
