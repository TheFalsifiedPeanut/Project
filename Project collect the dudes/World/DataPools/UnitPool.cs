using Collect_Dudes.Data.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Collect_Dudes.World.Generators;

namespace Collect_Dudes.World.DataPools
{
    internal class UnitPool : DataPool<Unit>
    {
        public UnitPool(int initialPoolSize) : base()
        {
            if (dataPool is null)
            {
                dataPool = this;
                for (int i = 0; i < initialPoolSize; i++)
                {
                    data.Add(UnitGenerator.GenerateUnit(FindFirstFreeID()));
                }
            }
        }
    }
}
