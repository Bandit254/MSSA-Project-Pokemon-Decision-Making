using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

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
        public int TeamPublic { get; set; }
        public TeamBase() { }
        public TeamBase(string teamBaseName, int pokemonOneId, int pokemonTwoId, int pokemonThreeId, int pokemonFourId, int pokemonFiveId, int pokemonSixId, int userId = 0, int? teamPublic=1)
        {
            TeamBaseName = teamBaseName;
            PokemonOneId = pokemonOneId;
            PokemonTwoId = pokemonTwoId;
            PokemonThreeId = pokemonThreeId;
            PokemonFourId = pokemonFourId;
            PokemonFiveId = pokemonFiveId;
            PokemonSixId = pokemonSixId;
            UserId = userId;
            TeamPublic = (int)teamPublic;
        }
        
        public virtual Pokemon PokemonFive { get; set; }
        
        public virtual Pokemon PokemonFour { get; set; }
        
        public virtual Pokemon PokemonOne { get; set; }
       
        public virtual Pokemon PokemonSix { get; set; }
       
        public virtual Pokemon PokemonThree { get; set; }
        
        public virtual Pokemon PokemonTwo { get; set; }
       
        public virtual Vgcplayer User { get; set; }

        public virtual void AddPokemonTB(Pokemon pokemon)
        {
            if (PokemonOneId == 0)
            {
                this.PokemonOneId = pokemon.PokemonId;
                PokemonOne = pokemon;
            }
            else if (PokemonTwoId == 0)
            {
                this.PokemonTwoId = pokemon.PokemonId;
                PokemonTwo = pokemon;
            }
            else if (PokemonThreeId == 0)
            {
                
                this.PokemonThreeId = pokemon.PokemonId;
                PokemonThree = pokemon;
            }
            else if (PokemonFourId == 0)
            {
                
                this.PokemonFourId = pokemon.PokemonId;
                PokemonFour = pokemon;
            }
            else if (PokemonFiveId == 0)
            {
               
                this.PokemonFiveId = pokemon.PokemonId;
                PokemonFive = pokemon;
            }
            else if (PokemonSixId == 0)
            {
                this.PokemonSixId = pokemon.PokemonId;
                PokemonSix = pokemon;
            }
        }
        public virtual void RemovePokemonTB(Pokemon pokemon)
        {
            if (pokemon.PokemonId==PokemonOneId)
            {
                PokemonOne = null;
                PokemonOneId = 0;
            }
            else if (pokemon.PokemonId==PokemonTwoId)
            {
                PokemonTwo = null;
                PokemonTwoId = 0;
            }
            else if (pokemon.PokemonId == PokemonThreeId)
            {
                PokemonThree = null;
                PokemonThreeId = 0;
            }
            else if (pokemon.PokemonId == PokemonFourId)
            {
                PokemonFour = null;
                PokemonFourId = 0;
            }
            else if (pokemon.PokemonId == PokemonFiveId)
            {
                PokemonFive = null;
                PokemonFiveId = 0;
            }
            else if (pokemon.PokemonId == PokemonSixId)
            {
                PokemonSix = null;
                PokemonSixId = 0;
            }
        }
        public virtual void ClearPokemonTB()
        {
            PokemonSix = null;
            PokemonSixId = 0;
            PokemonFive = null;
            PokemonFiveId = 0;
            PokemonFour = null;
            PokemonFourId =0;
            PokemonThree = null;
            PokemonThreeId = 0;
            PokemonTwo = null;
            PokemonTwoId = 0;
            PokemonOne = null;
            PokemonOneId = 0;
        }
        public virtual void SetTeamBaseName(string teamBaseName)
        {
            this.TeamBaseName = teamBaseName;
        }
        public virtual void MarkTeamBasePublic(int teamPublic)
        {
            this.TeamPublic = teamPublic;
        }

    }
}
