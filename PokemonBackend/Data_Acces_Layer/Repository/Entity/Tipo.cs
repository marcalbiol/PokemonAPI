using Acceso_BD.Repository.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PokemonBackend.Models
{
    public class Tipo
    {

        [Key]
        public int? Id { get; set; }
        public string? Tipo_pokemon { get; set; }

        public ICollection<Tipos_Habilidades>? Habilidades_tipos { get; set; }
        public ICollection<Tipos_Pokemons>? Tipos { get; set; }

        [NotMapped]
        public ICollection<TipoBonus>? Bonus { get; set; }
        [NotMapped]
        public ICollection<TipoBonus>? Bonuses { get; set; }

        public ICollection<Debilidades> Debilidades { get; set; }
        public ICollection<Fortalezas> Fortalezas { get; set; }

    }

    public class TipoBonus
    {

        [Key] 
        public int Id { get; set; } 
        public int IdTipo { get; set; }
        public Tipo? BonusEf { get; set; }
        public int EficazId { get; set; }
        public Tipo? BonusDeb { get; set; }
        public int DebilidadId { get; set; }

        
    }

    public class Debilidades
    {

        [Key]
        public int Id { get; set; }
        public int IdTipo { get; set; }
        public Tipo? BonusDeb { get; set; }
        public int DebilidadId { get; set; }     

    }

    public class Fortalezas
    {

        [Key]
        public int Id { get; set; }
        public int IdTipo { get; set; }
        public Tipo? BonusEf { get; set; }
        public int EficazId { get; set; }
    }

    public class ModificadorTipo
    {

        [Key]
        public int Id { get; set; }
        public int IdTipo { get; set; }
        public Modificador Modificador { get; set; }
        public Tipo? Bonus { get; set; }
        public int TipoBonusId { get; set; }
    }

    public enum Modificador
    {
        Fortaleza,
        Debilidad
    }


}