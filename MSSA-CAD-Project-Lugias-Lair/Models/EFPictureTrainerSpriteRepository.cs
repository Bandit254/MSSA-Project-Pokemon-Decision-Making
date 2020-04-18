using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MSSA_CAD_Project_Lugias_Lair.Models
{
    public class EFPictureTrainerSpriteRepository : IPictureTrainerSprite
    {
        private LugiasLair_DB_ProjectContext context;
        public EFPictureTrainerSpriteRepository(LugiasLair_DB_ProjectContext ctx)
        {
            context = ctx;
        }
        public IQueryable<PictureTrainerSprite> PictureTrainerSprites => context.PictureTrainerSprite;
    }
}
