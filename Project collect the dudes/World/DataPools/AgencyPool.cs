namespace Collect_Dudes.World.DataPools
{
    using Data.Groups;
    using Generators;

    internal class AgencyPool : DataPool<Agency>
    {
        public AgencyPool(int initialPoolSize) : base()
        {
            if (dataPool is null)
            {
                dataPool = this;
                for (int i = 0; i < initialPoolSize; i++)
                {
                    data.Add(AgencyGenerator.GenerateAgency(FindFirstFreeID(false)));
                }
            }
        }
        public static void AddAgency(Agency agency)
        {
            GetData().Add(agency);
        }
    }
}