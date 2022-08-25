using Collect_Dudes.Data.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace Collect_Dudes.Data.Competitions
{
    internal class League : IIdentifier, IName
    {
        int teamCount;
        public ushort id { get; set; }
        public string name { get; set; }

        ushort[] teams;
        CompetitionResults[] results;
        
        public League(ushort id, string name, int leagueSize)
        {
            this.id = id;
            this.name = name;
            teams = new ushort[leagueSize];
            results = new CompetitionResults[leagueSize];
        }

        public void AddTeam(ushort teamID)
        {
            if (teamCount < teams.Length)
            {
                teams[teamCount] = teamID;
                results[teamCount] = new CompetitionResults(teamID);
                teamCount++;
            }
        }

        public int GetLeagueSize()
        {
            return teams.Length;
        }
        public ushort GetTeamIDByIndex(int index)
        {
            return teams[index];
        }

        public CompetitionResults GetResultsByID(ushort id)
        {
           return results.First((competitionResult) => competitionResult.teamID == id);
        }
    }
}