using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MSSA_CAD_Project_Lugias_Lair.Models
{
    public class EFPictureSpriteRepository : IPictureSprite
    {
        private LugiasLair_DB_ProjectContext context;
        public EFPictureSpriteRepository(LugiasLair_DB_ProjectContext ctx)
        {
            context = ctx;
        }
        public IQueryable<PictureSprite> PictureSprites => context.PictureSprite;
    }
}
