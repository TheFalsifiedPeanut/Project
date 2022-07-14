using Collect_Dudes.Data.Groups;
using Collect_Dudes.Data.Units;
using Collect_Dudes.Serialization;
using Collect_Dudes.World.DataPools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collect_Dudes.World.Generators
{
    internal static class SquadGenerator
    {
        public static Squad GenerateSquad(ushort id, byte starLevel)
        {
            Random random = new Random();
            HashSet<ushort> unitIDs = new HashSet<ushort>();

            int unitCount = random.Next(InternalSettings.minSquadSize, InternalSettings.maxSquadSize);

            for (int i = 0; i < unitCount; i++)
            {
                Unit uniqueUnit = GetUniqueUnit(random);
                uniqueUnit.squadID = id;
                unitIDs.Add(uniqueUnit.id);
            }

            return new Squad(unitIDs, starLevel);
        }

        static Unit GetUniqueUnit(Random random)
        {
            int unitIndex = random.Next(0, UnitPool.GetDataCount());
            if (UnitPool.GetUnitByIndex(unitIndex).squadID == 0)
            {
                return UnitPool.GetUnitByIndex(unitIndex);
            }
            return GetUniqueUnit(random);
        }
    }
}
