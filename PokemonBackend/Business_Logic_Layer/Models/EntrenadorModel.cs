﻿using Business_Logic_Layer.Models;
using PokemonBackend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica_Negocio.Models
{
    public class EntrenadorModel
    {

        public int? Id { get; set; }
        public string? Nombre { get; set; }
        public virtual List<Entrenadores_Pokemon>? Entrenador_Pokemons { get; set; }

    }
}
