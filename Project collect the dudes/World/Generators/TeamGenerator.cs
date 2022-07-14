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
        public static Team TeamGenerator(ushort id, byte agencyStarLevel)
        {
            Random random = new Random();
            for (int i = 0; i < InternalSettings.teamSize; i++)
            {
                byte unitLevelIndex;
                byte unitLevel;
                List<Unit> unitRange;
                switch (agencyStarLevel)
                {
                    case 1:
                        unitRange = UnitPool.GetData().Where(unit => unit.starLevel == 1 || unit.starLevel == 2 || unit.starLevel == 3).ToList();
                        unitLevelIndex = (byte)(random.Next(1,7));
                        if (unitLevelIndex <= 2)
                        {
                            unitLevel = 1;
                        }
                        else if (unitLevelIndex <= 5)
                        {
                            unitLevel = 2;
                        }
                        else
                        {
                            unitLevel = 3;
                        }
                        break;
                    case 2:
                        unitRange = UnitPool.GetData().Where(unit => unit.starLevel == 1 || unit.starLevel == 2 || unit.starLevel == 3 || unit.starLevel == 4).ToList();
                        unitLevelIndex = (byte)(random.Next(1, 15));
                        if (unitLevelIndex <= 2)
                        {
                            unitLevel = 1;
                        }
                        else if (unitLevelIndex <= 8)
                        {
                            unitLevel = 2;
                        }
                        else if (unitLevelIndex <= 13)
                        {
                            unitLevel = 3;
                        }
                        else
                        {
                            unitLevel = 4;
                        }
                        break;
                    case 3:
                        unitRange = UnitPool.GetData().Where(unit => unit.starLevel == 2 || unit.starLevel == 3 || unit.starLevel == 4).ToList();
                        unitLevelIndex = (byte)(random.Next(1,12));
                        if (unitLevelIndex <= 4)
                        {
                            unitLevel = 2;
                        }
                        else if (unitLevelIndex <= 9)
                        {
                            unitLevel = 3;
                        }
                        else
                        {
                            unitLevel = 4;
                        }
                        break;
                    case 4:
                        unitRange = UnitPool.GetData().Where(unit => unit.starLevel == 2 || unit.starLevel == 3 || unit.starLevel == 4 || unit.starLevel == 5).ToList();
                        unitLevelIndex = (byte)(random.Next(1, 10));
                        if (unitLevelIndex <= 1)
                        {
                            unitLevel = 2;
                        }
                        else if (unitLevelIndex <= 5)
                        {
                            unitLevel = 3;
                        }
                        else if (unitLevelIndex <= 8)
                        {
                            unitLevel = 4;
                        }
                        else
                        {
                            unitLevel = 5;
                        }
                        break;
                    case 5:
                        unitRange = UnitPool.GetData().Where(unit => unit.starLevel == 3 || unit.starLevel == 4 || unit.starLevel == 5).ToList();
                        unitLevelIndex = (byte)(random.Next(1, 9));
                        if (unitLevelIndex <= 5)
                        {
                            unitLevel = 3;
                        }
                        else if (unitLevelIndex <= 7)
                        {
                            unitLevel = 4;
                        }
                        else
                        {
                            unitLevel = 5;
                        }
                        break;
                }
                
            }

            return new Team(id, "Team " + id, squadID);
        }
    }
}
