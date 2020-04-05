using System;
using System.Collections.Generic;

namespace MSSA_CAD_Project_Lugias_Lair.Models
{
    public partial class PictureFull
    {
        public int PicFullId { get; set; }
        public int PokemonId { get; set; }
        public string PicFullName { get; set; }
        public string PicFullFileName { get; set; }
        public byte[] PicFullData { get; set; }

        public virtual Pokemon Pokemon { get; set; }
    }
}
