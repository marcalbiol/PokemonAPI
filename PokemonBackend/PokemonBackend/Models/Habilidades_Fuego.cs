﻿using System.ComponentModel.DataAnnotations;

namespace PokemonBackend.Models
{
    public class Habilidades_Fuego
    {
        [Key]
        public int FuegoId { get; set; }    

        // Habilidades
        public string? Habilidad_1 { get; set; }    
        public string? Habilidad_2 { get; set; }    
        public string? Habilidad_3 { get; set; }    
        public string? Habilidad_4 { get; set; }    

        public int TipoId { get; set; }

        public Tipo? Tipo { get; set; }  
    }
}
