using System;
using System.Collections.Generic;

namespace MSSA_CAD_Project_Lugias_Lair.Models
{
    public partial class TeamBase
    {
        public int TeamBaseId { get; set; }
        public string TeamBaseName { get; set; }
        public int UserId { get; set; }
        public int PokemonOneId { get; set; }
        public int PokemonTwoId { get; set; }
        public int PokemonThreeId { get; set; }
        public int PokemonFourId { get; set; }
        public int PokemonFiveId { get; set; }
        public int PokemonSixId { get; set; }
        public int? TeamPublic { get; set; }

        public virtual Pokemon PokemonFive { get; set; }
        public virtual Pokemon PokemonFour { get; set; }
        public virtual Pokemon PokemonOne { get; set; }
        public virtual Pokemon PokemonSix { get; set; }
        public virtual Pokemon PokemonThree { get; set; }
        public virtual Pokemon PokemonTwo { get; set; }
        public virtual Vgcplayer User { get; set; }
    }
}
