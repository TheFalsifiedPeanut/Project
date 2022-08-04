using Collect_Dudes.Data.Competitions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Collect_Dudes.World.Enums;

namespace Collect_Dudes.World.DataPools
{
    internal class LeaguePool : DataPool<League>
    {
        public LeaguePool() : base()
        {
            data.Add(new League((ushort)LeagueIDs.Bronze, "Bronze League", 16));
            data.Add(new League((ushort)LeagueIDs.Silver, "Silver League", 16));
            data.Add(new League((ushort)LeagueIDs.Gold, "Gold League", 16));
            data.Add(new League((ushort)LeagueIDs.Platinum, "Platinum League", 16));
        }
    }
}
