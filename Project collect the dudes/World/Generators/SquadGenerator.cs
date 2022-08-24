namespace Collect_Dudes.World.Generators
{
    using Data.Groups;
    using Data.Units;
    using DataPools;
    using Serialization;
    using System;
    using System.Collections.Generic;

    internal static class SquadGenerator
    {
        public static Squad GenerateSquad(ushort id, int starLevel)
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

            return new Squad(id, starLevel, unitIDs);
        }

        static Unit GetUniqueUnit(Random random)
        {
            int unitIndex = random.Next(0, UnitPool.GetDataCount());
            if (UnitPool.GetDataByIndex(unitIndex).squadID == 0)
            {
                return UnitPool.GetDataByIndex(unitIndex);
            }
            return GetUniqueUnit(random);
        }
    }
}