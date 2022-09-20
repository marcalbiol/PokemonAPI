using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Logic_Layer.Models
{
    public class ZonaModel
    {
        public int? Id { get; set; }
        public string? NombreZona { get; set; }
        public string? ImageURL { get; set; }
        public List<PokeZonaModel>? Pokemon { get; set; }
    }

    // Dto para mostrar informacion necesaria desde Zona
    public class PokeZonaModel
    {
        public int? ID { get; set; }
        public string? Nombre { get; set; }
        public string? Altura { get; set; }
        public string? Peso { get; set; }
        public string? Imagen { get; set; }
    }

    public class PutZonaModel
    {
        public int? Id { get; set; }
        public string? NombreZona { get; set; }
        public string? ImageURL { get; set; }
    }
}