using System;
using System.Collections.Generic;

namespace MSSA_CAD_Project_Lugias_Lair.Models
{
    public partial class PokemonHasAbility
    {
        public int PkmnAbilityId { get; set; }
        public int PokemonId { get; set; }
        public int AbilityId { get; set; }
        public int HiddenAbility { get; set; }

        public virtual Ability Ability { get; set; }
        public virtual Pokemon Pokemon { get; set; }
    }
}
