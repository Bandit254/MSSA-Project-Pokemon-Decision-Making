﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MSSA_CAD_Project_Lugias_Lair.Models
{
    public interface IPokemonHasAbility
    {
        IQueryable<PokemonHasAbility> PokemonHasAbilities { get; }
    }
}
