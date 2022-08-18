using Collect_Dudes.Data.Groups;
using Collect_Dudes.World.Generators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collect_Dudes.World.DataPools
{
    internal class AgencyPool : DataPool<Agency>
    {
        public AgencyPool(int initialPoolSize) : base()
        {
            if (dataPool is null)
            {
                dataPool = this;
                for (int i = 0; i < initialPoolSize; i++)
                {
                    data.Add(AgencyGenerator.GenerateAgency(FindFirstFreeID()));
                }
            }
        }
        public static void AddAgency(Agency agency)
        {
            GetData().Add(agency);
        }
    }
}
