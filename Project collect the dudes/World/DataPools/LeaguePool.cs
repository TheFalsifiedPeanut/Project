namespace Collect_Dudes.World.DataPools
{
    using Data.Competitions;
    using Enums;

    internal class LeaguePool : DataPool<League>
    {
        public LeaguePool() : base()
        {
            data.Add(new League((ushort)LeagueIDs.Bronze, "Bronze League", 16));
            data.Add(new League((ushort)LeagueIDs.Silver, "Silver League", 16));
            data.Add(new League((ushort)LeagueIDs.Gold, "Gold League", 16));
            data.Add(new League((ushort)LeagueIDs.Platinum, "Platinum League", 16));
        }
    }
}