namespace Collect_Dudes.Screens.Competitions
{
    using Collect_Dudes.Data.Competitions;
    using Collect_Dudes.Data.Groups;
    using Collect_Dudes.Utilities;
    using Collect_Dudes.World.DataPools;
    using ConsoleUtilities.Screens;
    using System;

    internal class LeagueViewer : Screen
    {
        League league;

        public override void Render()
        {
            Console.WriteLine(" Standing |\tName\t   | Wins | Draws | Losses | Kills |  Casualties  |  Points  |");
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------");


            for (int i = 0; i < league.GetLeagueSize(); i++)
            {
                Team team = TeamPool.GetDataByID(league.GetTeamIDByIndex(i));
                CompetitionResults results = league.GetResultsByID(team.id);
                Console.WriteLine(TextUtilities.Spacing(9, i.ToString().Length) + i + " | " + TextUtilities.Spacing(18, team.name.Length) + team.name + " | " + TextUtilities.Spacing(4, results.wins.ToString().Length) + results.wins + " | " + TextUtilities.Spacing(5, results.draws.ToString().Length) + results.draws + " | " + TextUtilities.Spacing(6, results.losses.ToString().Length) + results.losses + " | " + TextUtilities.Spacing(5, 3) + "N/A | " + TextUtilities.Spacing(10, 3) + "N/A | " + TextUtilities.Spacing(6, results.points.ToString().Length) + results.points);
            }
            
        }

        public LeagueViewer(League league)
        {
            this.league = league;
        }
    }
}