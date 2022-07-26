using Acceso_BD.Repository.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PokemonBackend.Models
{
    public class Tipo
    {
        public int? Id { get; set; }
        public string? Tipo_pokemon { get; set; }
        public ICollection<Tipos_Habilidades>? habilidades_tipos { get; set; }

        public ICollection<Tipos_Pokemons>? Tipos { get; set; }

        [ForeignKey("Tipo_pokemon")]
        public string? Eficaz { get; set; }
        [ForeignKey("Tipo_pokemon")]
        public string? Debil { get; set; }
    }
}
