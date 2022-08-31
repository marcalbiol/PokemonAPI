using System.ComponentModel.DataAnnotations;

namespace PokemonBackend.Models
{
    public class Entrenadores_Pokemon
    {
        [Key]
        public int? Id { get; set; }
        public int? EntrenadorId { get; set; }
        public virtual Entrenador? Entrenador { get; set; }
        public int? PokemonId { get; set; }
        public virtual Pokemon? Pokemon { get; set; }
        public Boolean? Shiny { get; set; }
    }
}
