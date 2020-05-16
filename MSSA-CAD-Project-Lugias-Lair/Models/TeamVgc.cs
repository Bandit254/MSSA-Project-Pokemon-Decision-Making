using System;
using System.Collections.Generic;

namespace MSSA_CAD_Project_Lugias_Lair.Models
{
    public partial class TeamVgc
    {
        public int TeamVgcid { get; set; }
        public int UserId { get; set; }
        public int TeamBaseId { get; set; }
        public int PkmnVgconeId { get; set; }
        public int PkmnVgctwoId { get; set; }
        public int PkmnVgcthreeId { get; set; }
        public int PkmnVgcfourId { get; set; }

        public virtual Pokemon PkmnVgcfour { get; set; }
        public virtual Pokemon PkmnVgcone { get; set; }
        public virtual Pokemon PkmnVgcthree { get; set; }
        public virtual Pokemon PkmnVgctwo { get; set; }
        public virtual Vgcplayer User { get; set; }
        public TeamVgc() { }
        public TeamVgc(int userId, int teamBaseId, Pokemon pokemonOne, Pokemon pokemonTwo, Pokemon pokemonThree, Pokemon pokemonFour)
        {
            UserId = userId;
            TeamBaseId = teamBaseId;
            PkmnVgcone = pokemonOne;
            PkmnVgconeId = pokemonOne.PokemonId;
            PkmnVgctwo = pokemonTwo;
            PkmnVgctwoId = pokemonTwo.PokemonId;
            PkmnVgcthree = pokemonThree;
            PkmnVgcthreeId = pokemonThree.PokemonId;
            PkmnVgcfour = pokemonFour;
            PkmnVgcfourId = pokemonFour.PokemonId;
        }

        public TeamVgc(int userId, int teamBaseId, int pkmnOneId, int pkmnTwoId, int pkmnThreeId, int pkmnFourId)
        {
            UserId = userId;
            TeamBaseId = teamBaseId;
            PkmnVgconeId = pkmnOneId;
            PkmnVgctwoId = pkmnTwoId;
            PkmnVgcthreeId = pkmnThreeId;
            PkmnVgcfourId = pkmnFourId;
        }
        public void AddPokemonVGC(Pokemon pokemon)
        {
            if (PkmnVgconeId == 0 || PkmnVgconeId ==pokemon.PokemonId)
            {
                PkmnVgcone = pokemon;
            }
            else if (PkmnVgctwoId == 0 || PkmnVgctwoId == pokemon.PokemonId)
            {
                PkmnVgctwo = pokemon;
            }
            else if (PkmnVgcthreeId == 0 || PkmnVgcthreeId == pokemon.PokemonId)
            {
                PkmnVgcthree = pokemon;
            }
            else if (PkmnVgcfourId == 0 || PkmnVgcfourId == pokemon.PokemonId)
            {
                PkmnVgcfour = pokemon;
            }
        }
        public void RemovePokemonVGC(Pokemon pokemon)
        {
            if (PkmnVgconeId == pokemon.PokemonId)
            {
                PkmnVgcone = null;
                PkmnVgconeId = 0;
            }
            else if (PkmnVgctwoId == pokemon.PokemonId)
            {
                PkmnVgctwo = null;
                PkmnVgctwoId = 0;
            }
            else if (PkmnVgcthreeId == pokemon.PokemonId)
            {
                PkmnVgcthree = null;
                PkmnVgcthreeId = 0;
            }
            else if (PkmnVgcfourId == pokemon.PokemonId)
            {
                PkmnVgcfour = null;
                PkmnVgcfourId = 0;
            }
        }
        public void ClearPokemonVGC()
        {
            PkmnVgctwo = null;
            PkmnVgctwoId = 0;
            PkmnVgcthree = null;
            PkmnVgcthreeId = 0;
            PkmnVgcfour = null;
            PkmnVgcfourId = 0;
        }
    }
}
