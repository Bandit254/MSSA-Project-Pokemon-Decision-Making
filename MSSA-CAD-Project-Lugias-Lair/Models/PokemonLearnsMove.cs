using System;
using System.Collections.Generic;

namespace MSSA_CAD_Project_Lugias_Lair.Models
{
    public partial class PokemonLearnsMove
    {
        public int PkmnMoveId { get; set; }
        public int PokemonId { get; set; }
        public int MoveId { get; set; }

        public virtual PokemonMove Move { get; set; }
        public virtual Pokemon Pokemon { get; set; }
    }
}
