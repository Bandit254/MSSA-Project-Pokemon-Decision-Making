using System;
using System.Collections.Generic;

namespace MSSA_CAD_Project_Lugias_Lair.Models
{
    public partial class HeldItem
    {
        public HeldItem()
        {
            CustomPokemon = new HashSet<CustomPokemon>();
        }

        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public string ItemEffect { get; set; }
        public string ItemCat { get; set; }

        public virtual ICollection<CustomPokemon> CustomPokemon { get; set; }
    }
}
