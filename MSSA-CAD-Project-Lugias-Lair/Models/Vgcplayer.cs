using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

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
        [Required]
        [DisplayName("User Name")]
        public string UserName { get; set; }
        [Required]
        [DisplayName("Email Address")]
        public string UserEmail { get; set; }
        [Required]
        [DisplayName("Password")]
        public string UserPassword { get; set; }

        public virtual ICollection<CustomPokemon> CustomPokemon { get; set; }
        public virtual ICollection<TeamBase> TeamBase { get; set; }
        public virtual ICollection<TeamVgc> TeamVgc { get; set; }
    }
}
