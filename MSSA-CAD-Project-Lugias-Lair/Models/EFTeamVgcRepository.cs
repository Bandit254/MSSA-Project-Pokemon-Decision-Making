using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MSSA_CAD_Project_Lugias_Lair.Models
{
    public class EFTeamVgcRepository : ITeamVgc
    {
        private LugiasLair_DB_ProjectContext context;
        public EFTeamVgcRepository(LugiasLair_DB_ProjectContext ctx)
        {
            context = ctx;
        }
        public IQueryable<TeamVgc> TeamVgcs => context.TeamVgc;
        public void SaveTeamVgc(TeamVgc teamVgc)
        {
            if (teamVgc.TeamVgcid==0)
            {
                context.TeamVgc.Add(teamVgc);
            }
            else
            {
                TeamVgc dbEntry = context.TeamVgc.FirstOrDefault(v => v.TeamVgcid == teamVgc.TeamVgcid);
                if (dbEntry!=null)
                {
                    dbEntry.UserId = teamVgc.UserId;
                    dbEntry.TeamBaseId = teamVgc.TeamBaseId;
                    dbEntry.PkmnVgconeId = teamVgc.PkmnVgconeId;
                    dbEntry.PkmnVgctwoId = teamVgc.PkmnVgctwoId;
                    dbEntry.PkmnVgcthreeId = teamVgc.PkmnVgcthreeId;
                    dbEntry.PkmnVgcfourId = teamVgc.PkmnVgcfourId;
                }
            }
            context.SaveChanges();
        }
        public TeamVgc DeleteTeamVgc(int teamVgcId)
        {
            TeamVgc dbEntry = context.TeamVgc.FirstOrDefault(v => v.TeamVgcid == teamVgcId);
            if (dbEntry!=null)
            {
                context.TeamVgc.Remove(dbEntry);
                context.SaveChanges();
            }
            return dbEntry;
        }
    }
}
