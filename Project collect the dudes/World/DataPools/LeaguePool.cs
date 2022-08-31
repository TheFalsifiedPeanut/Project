namespace Collect_Dudes.World.DataPools
{
    using Collect_Dudes.Data.Groups;
    using Collect_Dudes.Data.Units.Enums;
    using Collect_Dudes.World.Generators;
    using Data.Competitions;
    using Enums;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class LeaguePool : DataPool<League>
    {
        public LeaguePool() : base()
        {
            League bronzeLeague = new League((ushort)LeagueIDs.Bronze, "Bronze League", 16);
            League silverLeague = new League((ushort)LeagueIDs.Silver, "Silver League", 16);
            League goldLeague = new League((ushort)LeagueIDs.Gold, "Gold League", 16);
            League platniumLeague = new League((ushort)LeagueIDs.Platinum, "Platinum League", 16);

            data.Add(bronzeLeague);
            data.Add(silverLeague);
            data.Add(goldLeague);
            data.Add(platniumLeague);

            List<Team> teams = TeamPool.GetData().Where((team) => team.starLevel == (int)StarLevel.ONE || team.starLevel == (int)StarLevel.TWO).ToList();

            Random random = new Random();
            for (int i = 0; i < bronzeLeague.GetLeagueSize(); i++)
            {
                if (teams.Count > 0)
                {
                    Team team = teams[random.Next(0, teams.Count)];
                    bronzeLeague.AddTeam(team.id);
                    teams.Remove(team);
                }
                else
                {
                    bronzeLeague.AddTeam(TeamGenerator.GenerateTeam(TeamPool.FindFirstFreeID(), random.Next(1, 3), AgencyGenerator.GenerateAgency(AgencyPool.FindFirstFreeID())).id);

                }


            }
            for (int i = 0; i < silverLeague.GetLeagueSize(); i++)
            {
                if (teams.Count > 0)
                {
                    Team team = teams[random.Next(0, teams.Count)];
                    silverLeague.AddTeam(team.id);
                    teams.Remove(team);
                }
                else
                {
                    silverLeague.AddTeam(TeamGenerator.GenerateTeam(TeamPool.FindFirstFreeID(), random.Next(1, 3), AgencyGenerator.GenerateAgency(AgencyPool.FindFirstFreeID(false))).id);
                    
                }

                
            }
            for (int i = 0; i < goldLeague.GetLeagueSize(); i++)
            {
                if (teams.Count > 0)
                {
                    Team team = teams[random.Next(0, teams.Count)];
                    goldLeague.AddTeam(team.id);
                    teams.Remove(team);
                }
                else
                {
                    goldLeague.AddTeam(TeamGenerator.GenerateTeam(TeamPool.FindFirstFreeID(), random.Next(1, 3), AgencyGenerator.GenerateAgency(AgencyPool.FindFirstFreeID(false))).id);
                    
                }

                
            }
            for (int i = 0; i < platniumLeague.GetLeagueSize(); i++)
            {
                if (teams.Count > 0)
                {
                    Team team = teams[random.Next(0, teams.Count)];
                    platniumLeague.AddTeam(team.id);
                    teams.Remove(team);
                }
                else
                {
                    platniumLeague.AddTeam(TeamGenerator.GenerateTeam(TeamPool.FindFirstFreeID(), random.Next(1, 3), AgencyGenerator.GenerateAgency(AgencyPool.FindFirstFreeID(false))).id);
                    
                }

                
            }
            for (int i = 0; i < bronzeLeague.GetLeagueSize(); i++)
            {
                if (teams.Count > 0)
                {
                    Team team = teams[random.Next(0, teams.Count)];
                    bronzeLeague.AddTeam(team.id);
                    teams.Remove(team);
                }
                else
                {
                    bronzeLeague.AddTeam(TeamGenerator.GenerateTeam(TeamPool.FindFirstFreeID(), random.Next(1, 3), AgencyGenerator.GenerateAgency(AgencyPool.FindFirstFreeID(false))).id);
                }

                
            }

        }
    }
}