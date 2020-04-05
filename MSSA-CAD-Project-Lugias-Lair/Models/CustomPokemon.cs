using System;
using System.Collections.Generic;

namespace MSSA_CAD_Project_Lugias_Lair.Models
{
    public partial class CustomPokemon
    {
        public int CustomPokemonId { get; set; }
        public int PokemonId { get; set; }
        public int PokedexEntryId { get; set; }
        public int UserId { get; set; }
        public string PokemonNickname { get; set; }
        public int PkmnTypeOneId { get; set; }
        public int? PkmnTypeTwoId { get; set; }
        public int? MoveOneId { get; set; }
        public int? MoveTwoId { get; set; }
        public int? MoveThreeId { get; set; }
        public int? MoveFourId { get; set; }
        public int? AbilityId { get; set; }
        public int? NatureId { get; set; }
        public int? CharacteristicId { get; set; }
        public int? ItemId { get; set; }
        public int? HitPointIv { get; set; }
        public int? AttackIv { get; set; }
        public int? DefenseIv { get; set; }
        public int? SpAttackIv { get; set; }
        public int? SpDefenseIv { get; set; }
        public int? SpeedIv { get; set; }
        public int? HitPointEv { get; set; }
        public int? AttackEv { get; set; }
        public int? DefenseEv { get; set; }
        public int? SpAttackEv { get; set; }
        public int? SpDefenseEv { get; set; }
        public int? SpeedEv { get; set; }
        public int? OverallHitPoints { get; set; }
        public int? OverallAttack { get; set; }
        public int? OverallDefense { get; set; }
        public int? OverallSpAttack { get; set; }
        public int? OverallSpDefense { get; set; }
        public int? OverallSpeed { get; set; }

        public virtual Ability Ability { get; set; }
        public virtual Characteristic Characteristic { get; set; }
        public virtual HeldItem Item { get; set; }
        public virtual PokemonMove MoveFour { get; set; }
        public virtual PokemonMove MoveOne { get; set; }
        public virtual PokemonMove MoveThree { get; set; }
        public virtual PokemonMove MoveTwo { get; set; }
        public virtual Nature Nature { get; set; }
        public virtual PokemonType PkmnTypeOne { get; set; }
        public virtual PokemonType PkmnTypeTwo { get; set; }
        public virtual PokedexEntry PokedexEntry { get; set; }
        public virtual Pokemon Pokemon { get; set; }
        public virtual Vgcplayer User { get; set; }
    }
}
