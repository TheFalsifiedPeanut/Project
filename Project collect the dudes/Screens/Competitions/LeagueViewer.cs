using Collect_Dudes.Data.Groups;
using ConsoleUtilities.Screens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collect_Dudes.Screens.Competitions
{
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
