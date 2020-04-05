using System;
using System.Collections.Generic;

namespace MSSA_CAD_Project_Lugias_Lair.Models
{
    public partial class Nature
    {
        public Nature()
        {
            CustomPokemon = new HashSet<CustomPokemon>();
        }

        public int NatureId { get; set; }
        public string NatureName { get; set; }
        public string NatureIncreses { get; set; }
        public string NatureDecreases { get; set; }
        public string NatureBerryDislike { get; set; }

        public virtual ICollection<CustomPokemon> CustomPokemon { get; set; }
    }
}
