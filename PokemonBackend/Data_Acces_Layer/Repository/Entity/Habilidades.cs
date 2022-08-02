using System.ComponentModel.DataAnnotations;
using Acceso_BD.Repository.Entity;

namespace PokemonBackend.Models
{
    public class Habilidades
    {
        [Key]
        public int? HabilidadId { get; set; }    

        // Habilidades
        public string? Habilidad_1 { get; set; }    
        public string? Habilidad_2 { get; set; }    
        public string? Habilidad_3 { get; set; }    
        public string? Habilidad_4 { get; set; }    
        public virtual ICollection<Tipos_Habilidades>? habilidades_tipos { get; set; }
    }
}
