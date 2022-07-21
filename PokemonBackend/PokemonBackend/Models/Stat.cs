namespace PokemonBackend.Models
{
    public class Stat
    {
        // relacionar esta tabla con pokemons. Solo se deberia asignar el nivel y mediante lógica y dependiendo de su nivel tendrá los stats predeterminados
        public int Id { get; set; }
        public int? Nivel { get; set; }
        public int? Ataque { get; set; }
        public int? Defensa { get; set; }
        public int? Vida { get; set; }
        public ICollection<Pokemon>? Pokemons { get; set; }  
    }
}
