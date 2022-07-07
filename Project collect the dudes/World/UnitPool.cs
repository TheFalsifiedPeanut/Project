using Collect_Dudes.Data.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Collect_Dudes.World.Generators;

namespace Collect_Dudes.World
{
    internal class UnitPool
    {
        static UnitPool unitPool;
        List<Unit> units;

        #region Getters
        public static int GetUnitCount()
        {
            return unitPool.units.Count;
        }

        public static Unit GetUnitByIndex(int index)
        {
            if (unitPool.units.Count > index)
            {
                return unitPool.units[index];
            }
            return null;
        }

        public static Unit GetUnitByID(ushort id)
        {
            for (int i = 0; i < unitPool.units.Count; i++)
            {
                if (unitPool.units[i].id == id)
                {
                    return unitPool.units[i];
                }
            }
            return null;
        }

        public static List<Unit> GetUnits()
        {
            return unitPool.units;
        }

        #endregion



        public UnitPool(int initialPoolSize)
        {
            if (unitPool is null)
            {
                unitPool = this;
                units = new List<Unit>();
                for (int i = 0; i < initialPoolSize; i++)
                {
                    units.Add(UnitGenerator.GenerateUnit(FindFirstFreeID()));
                }
            }
        }
        ushort FindFirstFreeID()
        {
            bool takenID = false;
            for (ushort i = 0; i < ushort.MaxValue; i++)
            {
                for (int j = 0; j < units.Count; j++)
                {
                    if (i == units[j].id)
                    {
                        takenID = true;
                        break;
                    }
                }
                if (takenID)
                {
                    takenID = false;
                }
                else
                {
                    return i;
                }
            }
            return 0;
        }
    }
}
