using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MSSA_CAD_Project_Lugias_Lair.Models
{
    public class EFPokemonTypeRepository : IPokemonType
    {
        private LugiasLair_DB_ProjectContext context;
        public EFPokemonTypeRepository(LugiasLair_DB_ProjectContext ctx)
        {
            context = ctx;
        }
        public IQueryable<PokemonType> PokemonTypes => context.PokemonType;
    }
}
