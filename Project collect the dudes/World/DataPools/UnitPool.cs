namespace Collect_Dudes.World.DataPools
{
    using Data.Units;
    using Generators;

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

        public static void AddUnit(Unit unit)
        {
            GetData().Add(unit);
        }
    }
}