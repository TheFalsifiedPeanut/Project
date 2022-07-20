namespace Collect_Dudes.Screens.Competitions
{
    using ConsoleUtilities.Screens;
    using Data.Groups;
    using System;
    using System.Collections.Generic;

    internal class LeagueViewer : Screen
    {
        List<Team> teams;

        int wins;
        int draws;
        int losses;

        public override void Render()
        {
            Console.WriteLine(" Standing |\tName\t   | Wins | Draws | Losses | Kills |  Casualties  |  Points  |");
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------");

            
            
        }
    }
}
