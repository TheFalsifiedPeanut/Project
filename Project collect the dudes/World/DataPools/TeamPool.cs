using Collect_Dudes.Data.Groups;
using Collect_Dudes.World.Generators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collect_Dudes.World.DataPools
{
    internal class TeamPool : DataPool<Team>
    {
        public TeamPool(int initialPoolSize) : base(initialPoolSize)
        {
            Random random = new Random();

            if (dataPool is null)
            {
                dataPool = this;
                for (int i = 0; i < AgencyPool.GetDataCount(); i++)
                {
                    Agency agency = AgencyPool.GetDataByIndex(i);
                    byte teamCount = 0;
                    byte agencyStarLevel = agency.starLevel;
                    switch (agencyStarLevel)
                    {
                        case 1:
                            teamCount = (byte)(random.Next(1, 3));
                            break;
                        case 2:
                            teamCount = (byte)(random.Next(1, 4));
                            break;
                        case 3:
                            teamCount = (byte)(random.Next(2, 4));
                            break;
                        case 4:
                            teamCount = (byte)(random.Next(2, 5));
                            break;
                        case 5:
                            teamCount = (byte)(random.Next(3, 5));
                            break;
                    }
                    switch (agencyStarLevel)
                    {
                        case 1:
                            for (int j = 0; j < teamCount; j++)
                            {

                                if (j == 0)
                                {
                                    TeamGenerator.TeamGenerator(id, (byte)(random.Next(1,4)), agency);
                                }
                                else if (j == 1)
                                {
                                    TeamGenerator.TeamGenerator(id, (byte)(random.Next(1, 3)), agency);
                                }
                                else
                                {
                                    TeamGenerator.TeamGenerator(id, (byte)(random.Next(2, 4)), agency);
                                }

                            }
                            break;
                        case 2:
                            for (int j = 0; j < teamCount; j++)
                            {
                                if (j == 0)
                                {
                                    TeamGenerator.TeamGenerator(id, (byte)(random.Next(1, 4)), agency);
                                }
                                else if (j == 1)
                                {
                                    TeamGenerator.TeamGenerator(id, (byte)(random.Next(1, 3)), agency);
                                }
                                else if (j == 2)
                                {
                                    TeamGenerator.TeamGenerator(id, (byte)(random.Next(2, 3)), agency);
                                }
                                else
                                {
                                    TeamGenerator.TeamGenerator(id, (byte)(random.Next(2, 4)), agency);
                                }
                                
                            }
                            break;
                        case 3:
                            for (int j = 0; j < teamCount; j++)
                            {
                                if (j == 0)
                                {
                                    TeamGenerator.TeamGenerator(id, (byte)(random.Next(1, 5)), agency);
                                }
                                else if (j == 1)
                                {
                                    TeamGenerator.TeamGenerator(id, (byte)(random.Next(1, 4)), agency);
                                }
                                else
                                {
                                    TeamGenerator.TeamGenerator(id, (byte)(random.Next(2, 4)), agency);
                                }

                            }
                            break;
                        case 4:
                            for (int j = 0; j < teamCount; j++)
                            {
                                if (j == 0 || j == 1)
                                {
                                    TeamGenerator.TeamGenerator(id, (byte)(random.Next(2, 5)), agency);
                                }
                                else
                                {
                                    TeamGenerator.TeamGenerator(id, (byte)(random.Next(2, 4)), agency);
                                }
                            }
                            break;
                        case 5:
                            for (int j = 0; j < teamCount; j++)
                            {
                                if (j == 0)
                                {
                                    TeamGenerator.TeamGenerator(id, 5, agency);
                                }
                                else if (j == 1 || j == 2)
                                {
                                    TeamGenerator.TeamGenerator(id, (byte)(random.Next(3, 6)), agency);
                                }
                                else
                                {
                                    TeamGenerator.TeamGenerator(id, (byte)(random.Next(2, 5)), agency);
                                }

                            }
                            break;
                    }
                }
            }
        }
    }
}
