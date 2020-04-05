using System;
using System.Collections.Generic;

namespace MSSA_CAD_Project_Lugias_Lair.Models
{
    public partial class Pokemon
    {
        public Pokemon()
        {
            CustomPokemon = new HashSet<CustomPokemon>();
            PictureFull = new HashSet<PictureFull>();
            PictureSprite = new HashSet<PictureSprite>();
            PokedexEntry = new HashSet<PokedexEntry>();
            PokemonHasAbility = new HashSet<PokemonHasAbility>();
            PokemonLearnsMove = new HashSet<PokemonLearnsMove>();
            TeamBasePokemonFive = new HashSet<TeamBase>();
            TeamBasePokemonFour = new HashSet<TeamBase>();
            TeamBasePokemonOne = new HashSet<TeamBase>();
            TeamBasePokemonSix = new HashSet<TeamBase>();
            TeamBasePokemonThree = new HashSet<TeamBase>();
            TeamBasePokemonTwo = new HashSet<TeamBase>();
            TeamVgcPkmnVgcfour = new HashSet<TeamVgc>();
            TeamVgcPkmnVgcone = new HashSet<TeamVgc>();
            TeamVgcPkmnVgcthree = new HashSet<TeamVgc>();
            TeamVgcPkmnVgctwo = new HashSet<TeamVgc>();
        }

        public int PokemonId { get; set; }
        public int? PokemonNumber { get; set; }
        public string PokemonName { get; set; }
        public int? PokemonTypeOne { get; set; }
        public int? PokemonTypeTwo { get; set; }
        public int? PokemonStatTotal { get; set; }
        public int? PokemonHitPoints { get; set; }
        public int? PokemonAttack { get; set; }
        public int? PokemonDefense { get; set; }
        public int? PokemonSpecialAttack { get; set; }
        public int? PokemonSpecialDefense { get; set; }
        public int? PokemonSpeed { get; set; }

        public virtual PokemonType PokemonTypeOneNavigation { get; set; }
        public virtual PokemonType PokemonTypeTwoNavigation { get; set; }
        public virtual ICollection<CustomPokemon> CustomPokemon { get; set; }
        public virtual ICollection<PictureFull> PictureFull { get; set; }
        public virtual ICollection<PictureSprite> PictureSprite { get; set; }
        public virtual ICollection<PokedexEntry> PokedexEntry { get; set; }
        public virtual ICollection<PokemonHasAbility> PokemonHasAbility { get; set; }
        public virtual ICollection<PokemonLearnsMove> PokemonLearnsMove { get; set; }
        public virtual ICollection<TeamBase> TeamBasePokemonFive { get; set; }
        public virtual ICollection<TeamBase> TeamBasePokemonFour { get; set; }
        public virtual ICollection<TeamBase> TeamBasePokemonOne { get; set; }
        public virtual ICollection<TeamBase> TeamBasePokemonSix { get; set; }
        public virtual ICollection<TeamBase> TeamBasePokemonThree { get; set; }
        public virtual ICollection<TeamBase> TeamBasePokemonTwo { get; set; }
        public virtual ICollection<TeamVgc> TeamVgcPkmnVgcfour { get; set; }
        public virtual ICollection<TeamVgc> TeamVgcPkmnVgcone { get; set; }
        public virtual ICollection<TeamVgc> TeamVgcPkmnVgcthree { get; set; }
        public virtual ICollection<TeamVgc> TeamVgcPkmnVgctwo { get; set; }
    }
}
