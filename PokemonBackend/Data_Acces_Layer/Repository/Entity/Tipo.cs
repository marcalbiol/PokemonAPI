using Acceso_BD.Repository.Entity;

namespace PokemonBackend.Models
{
    public class Tipo
    {
        public int? Id { get; set; }
        public string? Tipo_pokemon { get; set; }
        public string? Eficaz { get; set; }
        public string? Debil { get; set; }

        public ICollection<Tipos_Habilidades>? habilidades_tipos { get; set; }

        public ICollection<Tipos_Pokemons>? Tipos { get; set; }

    }
}
