using System;
using System.Collections.Generic;

namespace MSSA_CAD_Project_Lugias_Lair.Models
{
    public partial class PictureTrainerSprite
    {
        public int PicTrainerSpriteId { get; set; }
        public int PokemonId { get; set; }
        public string PicTrainerSpriteName { get; set; }
        public string PicTrainerSpriteFileName { get; set; }
        public byte[] PicTrainerSpriteData { get; set; }
    }
}
