using PokemonBackend.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acceso_BD.Repository.Entity
{
    public class Pokedex
    {
        [Key]
        public int? ID { get; set; } 
        public string? Nombre { get; set; }
        public string? Imagen { get; set; }

        public string? Altura { get; set; }
        public string? Peso { get; set; }

        //public int? StatId { get; set; }
        //public Stat? Stat { get; set; }
        public ICollection<Tipos_Pokemons>? Tipos { get; set; }

    }
}
