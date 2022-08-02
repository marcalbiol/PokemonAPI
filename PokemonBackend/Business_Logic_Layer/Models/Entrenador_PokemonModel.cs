using Business_Logic_Layer.Models;
using PokemonBackend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica_Negocio.Models
{
    public class Entrenador_PokemonModel
    {
        public int? EntrenadorId { get; set; }
        public List<EntrenadorModel>? Entrenador { get; set; }
        public int? PokemonId { get; set; }
        public List<PokemonModel>? Pokemon { get; set; }
    }
}
