using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica_Negocio.Models
{
    public class PutEntrenadorPokemonModel
    {
        public int? Id { get; set; }
        public int? EntrenadorId { get; set; }
        public int? PokemonId { get; set; }
    }
}
