﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MSSA_CAD_Project_Lugias_Lair.Models
{
    public interface ICharacteristic
    {
        IQueryable<Characteristic> Characteristics { get; }
    }
}