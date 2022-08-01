using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokemonBackend.Models;

namespace Acceso_BD.Repository.Entity
{
    public class Tipos_Habilidades
    {
        public int Id { get; set; }
        public int? HabilidadId { get; set; }
        public Habilidades? Habilidades { get; set; }    
        public int? TipoId { get; set; } 
        public Tipo? Tipo { get; set; } 


    }
}
