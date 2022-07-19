using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PokemonBackend.Models
{
    public class Pokemon
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int? Id { get; set; }
        public string? Nombre { get; set; }
        public string? Tipo { get; set; }
        public int? Nivel { get; set; }
        public int? Ataque { get; set; }
        public int? Defensa { get; set; }
        public int? Vida { get; set; }

        // public List<Entrenador>?Entrenadores { get; set; }

        /*
        public int? EntrenadorId { get; set; }
        public Entrenador? Entrenador { get; set; }
        */

    }
}
