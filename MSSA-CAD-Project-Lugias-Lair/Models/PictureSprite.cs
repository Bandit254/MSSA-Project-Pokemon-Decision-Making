using System;
using System.Collections.Generic;

namespace MSSA_CAD_Project_Lugias_Lair.Models
{
    public partial class PictureSprite
    {
        public int PicSpriteId { get; set; }
        public int PokemonId { get; set; }
        public string PicSpriteName { get; set; }
        public string PicSpriteFileName { get; set; }
        public byte[] PicSpriteData { get; set; }

        public virtual Pokemon Pokemon { get; set; }
    }
}
