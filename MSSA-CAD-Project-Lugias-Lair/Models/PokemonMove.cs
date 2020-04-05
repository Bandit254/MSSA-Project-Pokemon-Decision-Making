using System;
using System.Collections.Generic;

namespace MSSA_CAD_Project_Lugias_Lair.Models
{
    public partial class PokemonMove
    {
        public PokemonMove()
        {
            CustomPokemonMoveFour = new HashSet<CustomPokemon>();
            CustomPokemonMoveOne = new HashSet<CustomPokemon>();
            CustomPokemonMoveThree = new HashSet<CustomPokemon>();
            CustomPokemonMoveTwo = new HashSet<CustomPokemon>();
            PokemonLearnsMove = new HashSet<PokemonLearnsMove>();
        }

        public int MoveId { get; set; }
        public string MoveName { get; set; }
        public int? MoveType { get; set; }
        public string MoveCategory { get; set; }
        public int? MovePower { get; set; }
        public int? MoveAccuracy { get; set; }
        public int? MovePoints { get; set; }
        public string MoveEffect { get; set; }
        public int? MoveEffectProb { get; set; }

        public virtual PokemonType MoveTypeNavigation { get; set; }
        public virtual ICollection<CustomPokemon> CustomPokemonMoveFour { get; set; }
        public virtual ICollection<CustomPokemon> CustomPokemonMoveOne { get; set; }
        public virtual ICollection<CustomPokemon> CustomPokemonMoveThree { get; set; }
        public virtual ICollection<CustomPokemon> CustomPokemonMoveTwo { get; set; }
        public virtual ICollection<PokemonLearnsMove> PokemonLearnsMove { get; set; }
    }
}
