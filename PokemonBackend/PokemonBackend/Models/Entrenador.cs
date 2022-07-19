using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PokemonBackend.Models
{
    public class Entrenador
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int? Id { get; set; }

        [Required]
        [StringLength(100)]
        public string? Nombre { get; set; }
        [Required]
        public int PokemonId { get; set; }


        [ForeignKey("PokemonId")]
        public Pokemon? Pokemon{ get; set; }
        public int? Victorias { get; set; }
        public int? Derrotas { get; set; }

    }
}
