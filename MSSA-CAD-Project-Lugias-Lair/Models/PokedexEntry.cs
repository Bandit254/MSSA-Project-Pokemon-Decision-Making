using System;
using System.Collections.Generic;

namespace MSSA_CAD_Project_Lugias_Lair.Models
{
    public partial class PokedexEntry
    {
        public PokedexEntry()
        {
            CustomPokemon = new HashSet<CustomPokemon>();
        }

        public int PokedexEntryId { get; set; }
        public int PokemonId { get; set; }
        public string PokedexEntry1 { get; set; }

        public virtual Pokemon Pokemon { get; set; }
        public virtual ICollection<CustomPokemon> CustomPokemon { get; set; }
    }
}
