using Business_Logic_Layer.Models;
using PokemonBackend.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica_Negocio.Models
{
    public class EntrenadorModel
    {
       
        //TODO HACER RELACION MANYTOMANY DESDE AUTOMAPPER
        // AHORA SE HACE DESDE LAS ENTIDADES CON LAZY LOADING

        public virtual List<Entrenadores_Pokemon>? EntrenadoresPokemons{ get; set; }

        // public virtual List<Entrenadores_Pokemon>? Entrenador_Pokemons { get; set; }

    }
}
