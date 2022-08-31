using PokemonBackend.Models;
using System.ComponentModel.DataAnnotations;

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
        public virtual ICollection<Pokemon> Pokemons { get; set; }

        [MaxLength(3)]
        public int? Tier { get; set; }
        public Boolean? Basico { get; set; }
        public virtual ICollection<Tipos_Pokemons>? Tipos { get; set; }
        public int? RegionId { get; set; }
        public virtual Region? Region { get; set; }
        public int? ZonaId { get; set; }
        public virtual Zona? Zona { get; set; }

    }
}
