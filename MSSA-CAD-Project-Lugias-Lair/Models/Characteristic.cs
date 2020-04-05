using System;
using System.Collections.Generic;

namespace MSSA_CAD_Project_Lugias_Lair.Models
{
    public partial class Characteristic
    {
        public Characteristic()
        {
            CustomPokemon = new HashSet<CustomPokemon>();
        }

        public int CharacteristicId { get; set; }
        public string CharacteristicDescription { get; set; }
        public string BenefittingStat { get; set; }

        public virtual ICollection<CustomPokemon> CustomPokemon { get; set; }
    }
}
