using Collect_Dudes.Data.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collect_Dudes.Data.Groups
{
    internal class Squad
    {
        public ushort Id { get; set; }
        public string Name { get; set; }
        List<Unit> units { get; set; }
        List<Team> teams { get; set; }

        

        public void CreateTeam(ushort ID, string Name)
        {
            teams.Add(new Team);
        }
    }
}
