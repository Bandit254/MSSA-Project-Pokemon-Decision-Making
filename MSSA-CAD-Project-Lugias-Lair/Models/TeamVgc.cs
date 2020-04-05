using System;
using System.Collections.Generic;

namespace MSSA_CAD_Project_Lugias_Lair.Models
{
    public partial class TeamVgc
    {
        public int TeamVgcid { get; set; }
        public int UserId { get; set; }
        public int TeamBaseId { get; set; }
        public int PkmnVgconeId { get; set; }
        public int PkmnVgctwoId { get; set; }
        public int PkmnVgcthreeId { get; set; }
        public int PkmnVgcfourId { get; set; }

        public virtual Pokemon PkmnVgcfour { get; set; }
        public virtual Pokemon PkmnVgcone { get; set; }
        public virtual Pokemon PkmnVgcthree { get; set; }
        public virtual Pokemon PkmnVgctwo { get; set; }
        public virtual Vgcplayer User { get; set; }
    }
}
