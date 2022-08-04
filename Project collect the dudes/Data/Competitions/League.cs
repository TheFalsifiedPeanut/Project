using Collect_Dudes.Data.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collect_Dudes.Data.Competitions
{
    internal class League : IIdentifier, IName
    {
        public ushort id { get; set; }
        public string name { get; set; }

        ushort[] teams;

        
        public League(ushort id, string name, int leagueSize)
        {
            this.id = id;
            this.name = name;
            teams = new ushort[leagueSize];

        }

    }
}
