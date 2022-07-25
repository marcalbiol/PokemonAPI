using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PokemonBackend.Models
{
    public class Pokemon
    {
        
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int? Id { get; set; }
       
        public string? PokemonID { get; set; }
        public string? Nombre { get; set; }

        public Boolean? Shiny { get; set; }

        public int? StatId { get; set; }
        public Stat? Stat { get; set; }
        public ICollection<Tipos_Pokemons>? Tipos { get; set; }
        public ICollection<Entrenadores_Pokemon>? Entrenador_Pokemons { get; set; }


    }
}
