using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MSSA_CAD_Project_Lugias_Lair.Models
{
    public class EFPokemonRepository : IPokemon
    {
        private LugiasLair_DB_ProjectContext context;
        public EFPokemonRepository(LugiasLair_DB_ProjectContext ctx)
        {
            context = ctx;
        }
        public IQueryable<Pokemon> Pokemon => context.Pokemon;
    }
}
