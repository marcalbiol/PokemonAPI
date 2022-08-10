using PokemonBackend.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acceso_BD.Repository.Entity
{
    public class Region
    {
        [Key]
        public int? Id { get; set; }
        public string? Nombre { get; set; }
        public virtual ICollection<Pokedex>? Pokedex{ get; set; }
    }
}
