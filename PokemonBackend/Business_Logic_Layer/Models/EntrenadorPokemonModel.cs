using Business_Logic_Layer.Models;
using PokemonBackend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica_Negocio.Models
{
    public class EntrenadorPokemonModel
    {
        public int Id { get; set; }
        public int? EntrenadorId { get; set; }
        public virtual string? Entrenador { get; set; }
        public int? PokemonId { get; set; }
        public virtual string? Pokemon { get; set; }
    }
}
