using Acceso_BD.Repository.Entity;
using System.ComponentModel.DataAnnotations;

namespace PokemonBackend.Models
{
    public class Entrenadores_Pokemon
    {
        [Key]
        public int Id { get; set; } 
        public int? EntrenadorId{ get; set; }
        public Entrenador? Entrenador{ get; set; }
        public int? PokemonId { get; set; }
        public Pokemon? Pokemon{ get; set; }
    }
}
