using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PokemonBackend.Models
{
    public class Entrenador
    {
       
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int? Id { get; set; }
        public string? Nombre { get; set; }
        public ICollection<Entrenadores_Pokemon>? Entrenador_Pokemons{ get; set; }

    }
}
