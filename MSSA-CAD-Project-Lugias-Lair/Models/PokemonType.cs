using System;
using System.Collections.Generic;

namespace MSSA_CAD_Project_Lugias_Lair.Models
{
    public partial class PokemonType
    {
        public PokemonType()
        {
            CustomPokemonPkmnTypeOne = new HashSet<CustomPokemon>();
            CustomPokemonPkmnTypeTwo = new HashSet<CustomPokemon>();
            PokemonMove = new HashSet<PokemonMove>();
            PokemonPokemonTypeOneNavigation = new HashSet<Pokemon>();
            PokemonPokemonTypeTwoNavigation = new HashSet<Pokemon>();
        }

        public int TypeId { get; set; }
        public int? TypeNumber { get; set; }
        public string TypeName { get; set; }

        public virtual ICollection<CustomPokemon> CustomPokemonPkmnTypeOne { get; set; }
        public virtual ICollection<CustomPokemon> CustomPokemonPkmnTypeTwo { get; set; }
        public virtual ICollection<PokemonMove> PokemonMove { get; set; }
        public virtual ICollection<Pokemon> PokemonPokemonTypeOneNavigation { get; set; }
        public virtual ICollection<Pokemon> PokemonPokemonTypeTwoNavigation { get; set; }
    }
}
