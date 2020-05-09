using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using MSSA_CAD_Project_Lugias_Lair.Infrastructure;

namespace MSSA_CAD_Project_Lugias_Lair.Models
{
    public class TeamBaseSession : TeamBase
    {
        public static TeamBase GetTeamBase(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
            TeamBaseSession teamBase = session?.GetJson<TeamBaseSession>("TeamBase") ?? new TeamBaseSession();
            teamBase.Session = session;
            return teamBase;
        }
        [JsonIgnore]
        public ISession Session { get; set; }

        public override void AddPokemonTB(Pokemon pokemon)
        {
            base.AddPokemonTB(pokemon);
            Session.SetJson("TeamBase", this);
        }
        public override void RemovePokemonTB(Pokemon pokemon)
        {
            base.RemovePokemonTB(pokemon);
            Session.SetJson("TeamBase", this);
        }
        public override void ClearPokemonTB()
        {
            base.ClearPokemonTB();
            Session.Remove("TeamBase");
        }
        public override void SetTeamBaseName(string teamBaseName)
        {
            base.SetTeamBaseName(teamBaseName);
            Session.SetJson("TeamBase", this);
        }
    }
}
