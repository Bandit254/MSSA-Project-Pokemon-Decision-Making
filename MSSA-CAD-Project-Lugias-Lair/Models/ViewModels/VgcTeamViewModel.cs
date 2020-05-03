using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MSSA_CAD_Project_Lugias_Lair.Models;

namespace MSSA_CAD_Project_Lugias_Lair.Models.ViewModels
{
    public class VgcTeamViewModel
    {
        public struct TeamBaseStruct
        {
            private string pokemonOne;
            private string pokemonTwo;
            private string pokemonThree;
            private string pokemonFour;
            private string pokemonFive;
            private string pokemonSix;
            public string PkmnOne { get => this.pokemonOne; set => this.pokemonOne = PkmnOne; }
            public string PkmnTwo { get => this.pokemonTwo; set => this.pokemonTwo = PkmnTwo; }
            public string PkmnThree { get => this.pokemonThree; set => this.pokemonThree = PkmnThree; }
            public string PkmnFour { get => this.pokemonFour; set => this.pokemonFour = PkmnFour; }
            public string PkmnFive { get => this.pokemonFive; set => this.pokemonFive = PkmnFive; }
            public string PkmnSix { get => this.pokemonSix; set => this.pokemonSix = PkmnSix; }
        }
    }
}
