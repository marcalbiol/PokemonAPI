using PokemonBackend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Logic_Layer.Models
{
   public class PokemonModel
    {
        // aqui se puede modificar, no se sobreescribe cuando se cambia
        public int? Id { get; set; }

        public string? IdPokemons { get; set; } 
        public string? Nombre { get; set; }

        // a traves de la logica asignar si es shiny o no TO DO
        public Boolean? Shiny { get; set; }

        public int? StatId { get; set; }
        public Stat? Stat { get; set; }
        public ICollection<Tipos_Pokemons>? Tipos { get; set; }
        public ICollection<Entrenadores_Pokemon>? Entrenador_Pokemons { get; set; }
    }
}
