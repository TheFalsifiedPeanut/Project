using Collect_Dudes.Data.Groups;
using Collect_Dudes.World.Generators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collect_Dudes.World.DataPools
{
    internal class TeamPool : DataPool<Team>
    {
        public TeamPool(int initialPoolSize) : base(initialPoolSize)
        {
            Random random = new Random();

            if (dataPool is null)
            {
                dataPool = this;
                for (int i = 0; i < AgencyPool.GetDataCount(); i++)
                {
                    Agency agency = AgencyPool.GetDataByIndex(i);
                    byte teamCount = 0;
                    byte agencyStarLevel = agency.starLevel;
                    switch (agencyStarLevel)
                    {
                        case 1:
                            teamCount = (byte)(random.Next(1, 3));
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
                    for (int j = 0; j < teamCount; j++)
                    {
                        TeamGenerator.TeamGenerator(, agency);
                    }
                }
            }
        }
    }
}
