using Acceso_BD.Repository.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PokemonBackend.Models
{
    public class Pokemon
    {
        
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int? Id { get; set; }
        public string? Nombre { get; set; }
        public Boolean? Shiny { get; set; }
     
        public int Nivel { get; set; }
        public int? PokedexId { get; set; }
        public Pokedex? Pokedex{ get; set; }
        
        /*
        public Boolean? BasicoId { get; set; }
        public Pokedex Basico { get; set; }
        public int? TierId { get; set; }
        public Pokedex Tier { get; set; }
         */
        public int? StatId { get; set; }
        public Stat? Stat { get; set; }
      
       public ICollection<Tipos_Pokemons>? Tipos { get; set; }
       
       public ICollection<Entrenadores_Pokemon>? Entrenador_Pokemons { get; set; }


    }
}
