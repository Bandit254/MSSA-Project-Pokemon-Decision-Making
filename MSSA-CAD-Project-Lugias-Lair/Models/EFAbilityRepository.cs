using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MSSA_CAD_Project_Lugias_Lair.Models
{
    public class EFAbilityRepository : IAbility
    {
        private LugiasLair_DB_ProjectContext context;
        public EFAbilityRepository(LugiasLair_DB_ProjectContext ctx)
        {
            context = ctx;
        }
        public IQueryable<Ability> Abilities => context.Ability;
    }
}
