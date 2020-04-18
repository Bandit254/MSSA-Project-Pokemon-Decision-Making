using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MSSA_CAD_Project_Lugias_Lair.Models
{
    public class EFCustomPokemonRepository : ICustomPokemon
    {
        private LugiasLair_DB_ProjectContext context;
        public EFCustomPokemonRepository(LugiasLair_DB_ProjectContext ctx)
        {
            context = ctx;
        }
        public IQueryable<CustomPokemon> CustomPokemons => context.CustomPokemon;
        public void SaveCustomPokemon(CustomPokemon customPokemon)
        {
            if (customPokemon.CustomPokemonId==0)
            {
                context.CustomPokemon.Add(customPokemon);
            }
            else
            {
                CustomPokemon dbEntry = context.CustomPokemon.FirstOrDefault(c => c.CustomPokemonId == customPokemon.CustomPokemonId);
                if (dbEntry!=null)
                {
                    dbEntry.PokemonId = customPokemon.PokemonId;
                    dbEntry.PokedexEntryId = customPokemon.PokedexEntryId;
                    dbEntry.UserId = customPokemon.UserId;
                    dbEntry.PokemonNickname = customPokemon.PokemonNickname;
                    dbEntry.PkmnTypeOneId = customPokemon.PkmnTypeOneId;
                    dbEntry.PkmnTypeTwoId = customPokemon.PkmnTypeTwoId;
                    dbEntry.MoveOneId = customPokemon.MoveOneId;
                    dbEntry.MoveTwoId = customPokemon.MoveTwoId;
                    dbEntry.MoveThreeId = customPokemon.MoveThreeId;
                    dbEntry.MoveFourId = customPokemon.MoveFourId;
                    dbEntry.AbilityId = customPokemon.AbilityId;
                    dbEntry.NatureId = customPokemon.NatureId;
                    dbEntry.CharacteristicId = customPokemon.CharacteristicId;
                    dbEntry.ItemId = customPokemon.ItemId;
                    dbEntry.HitPointIv = customPokemon.HitPointIv;
                    dbEntry.AttackIv = customPokemon.AttackIv;
                    dbEntry.DefenseIv = customPokemon.DefenseIv;
                    dbEntry.SpAttackIv = customPokemon.SpAttackIv;
                    dbEntry.SpDefenseIv = customPokemon.SpDefenseIv;
                    dbEntry.SpeedIv = customPokemon.SpeedIv;
                    dbEntry.HitPointEv = customPokemon.HitPointEv;
                    dbEntry.AttackEv = customPokemon.AttackEv;
                    dbEntry.DefenseEv = customPokemon.DefenseEv;
                    dbEntry.SpAttackEv = customPokemon.SpAttackEv;
                    dbEntry.SpDefenseEv = customPokemon.SpDefenseEv;
                    dbEntry.SpeedEv = customPokemon.SpDefenseEv;
                    dbEntry.OverallHitPoints = customPokemon.OverallHitPoints;
                    dbEntry.OverallAttack = customPokemon.OverallAttack;
                    dbEntry.OverallDefense = customPokemon.OverallDefense;
                    dbEntry.OverallSpAttack = customPokemon.OverallSpAttack;
                    dbEntry.OverallSpDefense = customPokemon.OverallSpDefense;
                    dbEntry.OverallSpeed = customPokemon.OverallSpeed;
                }
            }
            context.SaveChanges();
        }
        public CustomPokemon DeleteCustomPokemon(int customPokemonId)
        {
            CustomPokemon dbEntry = context.CustomPokemon.FirstOrDefault(c => c.CustomPokemonId == customPokemonId);
            if (dbEntry!=null)
            {
                context.CustomPokemon.Remove(dbEntry);
                context.SaveChanges();
            }
            return dbEntry;
        }
    }
}
