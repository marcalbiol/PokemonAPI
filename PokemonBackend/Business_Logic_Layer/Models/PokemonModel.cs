using Logica_Negocio.Models;
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
        public string? Nombre { get; set; }
        public Boolean? Shiny { get; set; }
        public virtual Entrenador Entrenador { get; set; }
    }
}
