namespace Collect_Dudes.World.DataPools
{
    using Data.Groups;
    using Generators;
    using System;

    internal class TeamPool : DataPool<Team>
    {
        public TeamPool() : base()
        {
            Random random = new Random();
            if (dataPool is null)
            {
                Console.WriteLine("TeamPool");
                dataPool = this;
                for (int i = 0; i < AgencyPool.GetDataCount(); i++)
                {
                    Agency agency = AgencyPool.GetDataByIndex(i);
                    int teamCount = 0;
                    int agencyStarLevel = agency.starLevel;
                    switch (agencyStarLevel)
                    {
                        case 1:
                            teamCount = random.Next(1, 3);
                            break;
                        case 2:
                            teamCount = random.Next(1, 4);
                            break;
                        case 3:
                            teamCount = random.Next(2, 4);
                            break;
                        case 4:
                            teamCount = random.Next(2, 5);
                            break;
                        case 5:
                            teamCount = random.Next(3, 5);
                            break;
                    }
                    switch (agencyStarLevel)
                    {
                        case 1:
                            for (int j = 0; j < teamCount; j++)
                            {
                                ushort id = FindFirstFreeID();

                                if (j == 0)
                                {
                                    TeamGenerator.GenerateTeam(id, random.Next(1, 4), agency);
                                }
                                else if (j == 1)
                                {
                                    TeamGenerator.GenerateTeam(id, random.Next(1, 3), agency);
                                }
                                else
                                {
                                    TeamGenerator.GenerateTeam(id, random.Next(2, 4), agency);
                                }

                            }
                            break;
                        case 2:

                            for (int j = 0; j < teamCount; j++)
                            {
                                ushort id = FindFirstFreeID();
                                if (j == 0)
                                {
                                    TeamGenerator.GenerateTeam(id, random.Next(1, 4), agency);
                                }
                                else if (j == 1)
                                {
                                    TeamGenerator.GenerateTeam(id, random.Next(1, 3), agency);
                                }
                                else if (j == 2)
                                {
                                    TeamGenerator.GenerateTeam(id, random.Next(2, 3), agency);
                                }
                                else
                                {
                                    TeamGenerator.GenerateTeam(id, random.Next(2, 4), agency);
                                }

                            }
                            break;
                        case 3:
                            for (int j = 0; j < teamCount; j++)
                            {
                                ushort id = FindFirstFreeID();
                                if (j == 0)
                                {
                                    TeamGenerator.GenerateTeam(id, random.Next(1, 5), agency);
                                }
                                else if (j == 1)
                                {
                                    TeamGenerator.GenerateTeam(id, random.Next(1, 4), agency);
                                }
                                else
                                {
                                    TeamGenerator.GenerateTeam(id, random.Next(2, 4), agency);
                                }

                            }
                            break;
                        case 4:
                            for (int j = 0; j < teamCount; j++)
                            {
                                ushort id = FindFirstFreeID();
                                if (j == 0 || j == 1)
                                {
                                    TeamGenerator.GenerateTeam(id, random.Next(2, 5), agency);
                                }
                                else
                                {
                                    TeamGenerator.GenerateTeam(id, random.Next(2, 4), agency);
                                }
                            }
                            break;
                        case 5:
                            for (int j = 0; j < teamCount; j++)
                            {
                                ushort id = FindFirstFreeID();
                                if (j == 0)
                                {
                                    TeamGenerator.GenerateTeam(id, 5, agency);
                                }
                                else if (j == 1 || j == 2)
                                {
                                    TeamGenerator.GenerateTeam(id, random.Next(3, 6), agency);
                                }
                                else
                                {
                                    TeamGenerator.GenerateTeam(id, random.Next(2, 5), agency);
                                }

                            }
                            break;
                    }
                }

            }
        }

        protected override Team GetDefault(ushort id)
        {
            return default(Team);
        }
    }
}