﻿using Business_Logic_Layer.Models;
using PokemonBackend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica_Negocio.Models
{
    public class EntrenadorPokemonModel
    {
        public int? Id { get; set; }
        public string? Pokemon { get; set; }
        public string? Entrenador { get; set; }
        public Boolean? Shiny { get; set; }
    }
}