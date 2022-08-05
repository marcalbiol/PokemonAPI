using PokemonBackend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica_Negocio.Models
{
    public class PokedexModel
    {
        public int? ID { get; set; }
        public string? Nombre { get; set; }
        public string? Altura { get; set; }
        public string? Peso { get; set; }
        public string? Imagen { get; set; }
    }
}
