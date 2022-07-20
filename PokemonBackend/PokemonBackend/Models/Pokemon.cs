using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PokemonBackend.Models
{
    public class Pokemon
    {
        
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int? Id { get; set; }
        public string? Nombre { get; set; }
        public int? Nivel { get; set; }
        public int? Ataque { get; set; }
        public int? Defensa { get; set; }
        public int? Vida { get; set; }
        public ICollection<Tipo_Pokemons>? Tipos { get; set; }
        public ICollection<Entrenador_Pokemon>? Entrenador_Pokemons { get; set; }


    }
}
