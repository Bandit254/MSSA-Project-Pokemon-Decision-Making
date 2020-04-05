using System;
using System.Collections.Generic;

namespace MSSA_CAD_Project_Lugias_Lair.Models
{
    public partial class Ability
    {
        public Ability()
        {
            CustomPokemon = new HashSet<CustomPokemon>();
            PokemonHasAbility = new HashSet<PokemonHasAbility>();
        }

        public int AbilityId { get; set; }
        public string AbilityName { get; set; }
        public string AbilityDescription { get; set; }

        public virtual ICollection<CustomPokemon> CustomPokemon { get; set; }
        public virtual ICollection<PokemonHasAbility> PokemonHasAbility { get; set; }
    }
}
