using Collect_Dudes.Data.General;
using Collect_Dudes.Data.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collect_Dudes.Data.Groups
{
    internal class Team : IName
    {
        public ushort Id { get; set; }
        public ushort squadID { get; set; }
        public string name { get; set; }
        List<Unit> units { get; set; }

        public Team(ushort id, ushort squadID, string name)
        {
            Id = id;
            this.squadID = squadID;
            this.name = name;
            units = new List<Unit>();
        }

        public void AddUnit(Unit unit)
        {
            unit.teamID = Id;
            units.Add(unit);
        }
    }
}
