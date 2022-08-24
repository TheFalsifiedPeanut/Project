namespace Collect_Dudes.Screens.Competitions
{
    using Collect_Dudes.Data.Competitions;
    using ConsoleUtilities.Screens;
    using System;

    internal class LeagueViewer : Screen
    {
        League league;

        public override void Render()
        {
            Console.WriteLine(" Standing |\tName\t   | Wins | Draws | Losses | Kills |  Casualties  |  Points  |");
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------");

            
            
        }
    }
}