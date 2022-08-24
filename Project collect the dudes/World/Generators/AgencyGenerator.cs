namespace Collect_Dudes.World.Generators
{
    using Data.Groups;
    using Serialization;
    using System;

    internal static class AgencyGenerator
    {
        public static Agency GenerateAgency(ushort id)
        {
            Random random = new Random();
            int starLevel = random.Next(1, 6);
            int minMoneyValue = 0;
            int maxMoneyValue = 0;
            switch (starLevel)
            {
                case 1:
                    minMoneyValue = InternalSettings.baseMoney;
                    maxMoneyValue = InternalSettings.oneStarMoneyMaximum;
                    break;
                case 2:
                    minMoneyValue = InternalSettings.oneStarMoneyMaximum;
                    maxMoneyValue = InternalSettings.twoStarMoneyMaximum;
                    break;
                case 3:
                    minMoneyValue = InternalSettings.twoStarMoneyMaximum;
                    maxMoneyValue = InternalSettings.threeStarMoneyMaximum;
                    break;
                case 4:
                    minMoneyValue = InternalSettings.threeStarMoneyMaximum;
                    maxMoneyValue = InternalSettings.fourStarMoneyMaximum;
                    break;
                case 5:
                    minMoneyValue = InternalSettings.fourStarMoneyMaximum;
                    maxMoneyValue = InternalSettings.fiveStarMoneyMaximum;
                    break;
            }

            return new Agency(id, "Agency " + id, (byte)(starLevel), random.Next(minMoneyValue, maxMoneyValue), SquadGenerator.GenerateSquad(id, (byte)(starLevel)));
        }
    }
}