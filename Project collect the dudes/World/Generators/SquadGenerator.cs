namespace Collect_Dudes.World.Generators
{
    using Data.Groups;
    using Data.Units;
    using DataPools;
    using Serialization;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal static class SquadGenerator
    {
        public static Squad GenerateSquad(ushort id, int starLevel)
        {
            Random random = new Random();
            HashSet<ushort> unitIDs = new HashSet<ushort>();

            int unitCount = random.Next(InternalSettings.minSquadSize, InternalSettings.maxSquadSize);

            List<Unit> units = UnitPool.GetData().Where((unit) => unit.squadID == 0).ToList();
            int unitsRemaining = units.Count - unitCount;
            if (unitsRemaining < 0) ;
            {
                for (int i = 0; i < MathF.Abs(unitsRemaining); i++)
                {
                    units.Add(UnitGenerator.GenerateUnit(UnitPool.FindFirstFreeID()));
                }
            }
            for (int i = 0; i < unitCount; i++)
            {
                Console.WriteLine("ID: " + id + " Unit Count: " + unitCount + " Units Remaining: " + units.Count);
                Unit uniqueUnit = units[random.Next(0, units.Count)];
                uniqueUnit.squadID = id;
                unitIDs.Add(uniqueUnit.id);
                units.Remove(uniqueUnit);
                
            }

            return new Squad(id, starLevel, unitIDs);
        }

    }
}