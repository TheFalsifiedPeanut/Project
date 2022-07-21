using Collect_Dudes.Data.Groups;
using Collect_Dudes.Data.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Collect_Dudes.Serialization;
using Collect_Dudes.World.DataPools;
using Collect_Dudes.Data.Units.Enums;

namespace Collect_Dudes.World.Generators
{
    internal static class TeamGenerator
    {
        public static Team GenerateTeam(ushort id, byte starLevel, Agency agency)
        {
            Random random = new Random();
            HashSet<ushort> units = new HashSet<ushort>();
            for (int i = 0; i < InternalSettings.teamSize; i++)
            {
                byte unitLevelIndex;
                byte unitLevel = 1;
                switch (agency.starLevel)
                {
                    case 1:
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

                List<Unit> unitRange = agency.squad.GetUnitsAsUnit().Where(unit => unit.starLevel == unitLevel && unit.teamID != 0).ToList();
                Unit newUnit;
                if (unitRange.Count > 0)
                {
                    newUnit = unitRange[random.Next(0, unitRange.Count)];
                }
                else
                {
                    newUnit = UnitGenerator.GenerateUnit(UnitPool.FindFirstFreeID(), (StarLevel)(unitLevel));
                }
                newUnit.teamID = id;
                units.Add(newUnit.id);
            }

            return new Team(id, "Team " + id, agency.id, starLevel, units);
        }
    }
}
