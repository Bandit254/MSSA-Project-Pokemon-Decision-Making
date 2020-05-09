using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MSSA_CAD_Project_Lugias_Lair.Models
{
    public class EFTeamBaseRepository : ITeamBase
    {
        private LugiasLair_DB_ProjectContext context;
        public EFTeamBaseRepository(LugiasLair_DB_ProjectContext ctx)
        {
            context = ctx;
        }
        public IQueryable<TeamBase> TeamBases => context.TeamBase;
        public void SaveTeamBase(TeamBase teamBase)
        {
            if (teamBase.TeamBaseId==0)
            {
                context.TeamBase.Add(teamBase);
            }
            else
            {
                TeamBase dbEntry = context.TeamBase.FirstOrDefault(t => t.TeamBaseId == teamBase.TeamBaseId);
                if (dbEntry!=null)
                {
                    dbEntry.TeamBaseName = teamBase.TeamBaseName;
                    dbEntry.PokemonOneId = teamBase.PokemonOneId;
                    dbEntry.PokemonTwoId = teamBase.PokemonTwoId;
                    dbEntry.PokemonThreeId = teamBase.PokemonThreeId;
                    dbEntry.PokemonFourId = teamBase.PokemonFourId;
                    dbEntry.PokemonFiveId = teamBase.PokemonFiveId;
                    dbEntry.PokemonSixId = teamBase.PokemonSixId;
                    dbEntry.UserId = teamBase.UserId;
                    dbEntry.TeamPublic = teamBase.TeamPublic;
                }
            }
            //context.Database.ExecuteSqlRaw("SET IDENTITY_INSERT dbo.Pokemon ON");
            context.SaveChanges();
            //context.Database.ExecuteSqlRaw("SET IDENTITY_INSERT dbo.TeamBase OFF");
        }
        public TeamBase DeleteTeamBase(int teamBaseId)
        {
            TeamBase dbEntry = context.TeamBase.FirstOrDefault(t => t.TeamBaseId == teamBaseId);
            if (dbEntry!=null)
            {
                context.TeamBase.Remove(dbEntry);
                context.SaveChanges();
            }
            return dbEntry;
        }
    }
}
