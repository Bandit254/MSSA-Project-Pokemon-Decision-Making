using System;
using System.Collections.Generic;

namespace MSSA_CAD_Project_Lugias_Lair.Models
{
    public partial class Vgcplayer
    {
        public Vgcplayer()
        {
            CustomPokemon = new HashSet<CustomPokemon>();
            TeamBase = new HashSet<TeamBase>();
            TeamVgc = new HashSet<TeamVgc>();
        }

        public int UserId { get; set; }
        public string UserName { get; set; }
        public string UserEmail { get; set; }
        public string UserPassword { get; set; }

        public virtual ICollection<CustomPokemon> CustomPokemon { get; set; }
        public virtual ICollection<TeamBase> TeamBase { get; set; }
        public virtual ICollection<TeamVgc> TeamVgc { get; set; }
    }
}
