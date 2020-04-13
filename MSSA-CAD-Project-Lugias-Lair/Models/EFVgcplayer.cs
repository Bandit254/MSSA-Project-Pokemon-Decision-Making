using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MSSA_CAD_Project_Lugias_Lair.Models
{
    public class EFVgcplayer : IVgcplayer
    {
        private LugiasLair_DB_ProjectContext context;
        public EFVgcplayer(LugiasLair_DB_ProjectContext ctx)
        {
            context = ctx;
        }
        public IQueryable<Vgcplayer> Vgcplayers => context.Vgcplayer;
        public void SaveVgcplayer(Vgcplayer vgcplayer)
        {
            context.AttachRange(vgcplayer);
            if (vgcplayer.UserId==0)
            {
                context.Vgcplayer.Add(vgcplayer);
            }
            context.SaveChanges();
        }
    }
}
