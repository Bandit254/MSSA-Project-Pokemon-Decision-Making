using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MSSA_CAD_Project_Lugias_Lair.Models
{
    public interface ITeamBase
    {
        IQueryable<TeamBase> TeamBases { get; }
        void SaveTeamBase(TeamBase teamBase);
        TeamBase DeleteTeamBase(int teamBaseId);
    }
}
