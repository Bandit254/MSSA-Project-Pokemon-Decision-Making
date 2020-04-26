using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MSSA_CAD_Project_Lugias_Lair.Models
{
    public class EFVgcplayerRepository : IVgcplayer
    {
        private LugiasLair_DB_ProjectContext context;
        public EFVgcplayerRepository(LugiasLair_DB_ProjectContext ctx)
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
            else
            {
                Vgcplayer dbEntry = context.Vgcplayer.FirstOrDefault(p => p.UserId == vgcplayer.UserId);
                if (dbEntry!=null)
                {
                    dbEntry.UserName = vgcplayer.UserName;
                    dbEntry.UserEmail = vgcplayer.UserEmail;
                    dbEntry.UserPassword = vgcplayer.UserPassword;
                }
            }
            context.SaveChanges();
        }
        public Vgcplayer DeleteVgcPlayer(int userId)
        {
            Vgcplayer dbEntry = context.Vgcplayer.FirstOrDefault(p => p.UserId == userId);
            if (dbEntry!=null)
            {
                context.Vgcplayer.Remove(dbEntry);
                context.SaveChanges();
            }
            return dbEntry;
        }
    }
}
