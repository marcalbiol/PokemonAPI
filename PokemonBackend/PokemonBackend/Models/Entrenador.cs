using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PokemonBackend.Models
{
    public class Entrenador
    {
       
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int? Id { get; set; }
        public string? Nombre { get; set; }
        public ICollection<Pokemon>? Pokemons { get; set; }

    }
}
