using Collect_Dudes.Data.Groups;
using Collect_Dudes.Data.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Collect_Dudes.Serialization;
using Collect_Dudes.World.DataPools;

namespace Collect_Dudes.World.Generators
{
    internal static class TeamGenerator
    {
        public static Team TeamGenerator(ushort id, ushort squadID)
        {
            Random random = new Random();
            byte teamCount = 0;
            byte agencyStarLevel = AgencyPool.GetDataByID(squadID).starLevel;
            switch (agencyStarLevel)
            {
                case 1:
                    teamCount = (byte)(random.Next(1,3));
                    break;
                case 2:
                    teamCount = (byte)(random.Next(1, 4));
                    break;
                case 3:
                    teamCount = (byte)(random.Next(2, 4));
                    break;
                case 4:
                    teamCount = (byte)(random.Next(2, 5));
                    break;
                case 5:
                    teamCount = (byte)(random.Next(3, 5));
                    break;
            }
            for (int i = 0; i < InternalSettings.teamSize; i++)
            {

            }

            return new Team(id, "Team " + id, squadID);
        }
    }
}
