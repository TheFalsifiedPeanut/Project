using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleUtilities.Inputs;

namespace Collect_Dudes.Screens.Menu
{
    class PlayMenu : Screen
    {
        public override void Render()
        {
            byte choice = Inputs.ChoiceDialogue("CHOOSE", "-Ominous-", new Dictionary<ConsoleKey, ChoiceEntry>()
            {
                {ConsoleKey.UpArrow, new ChoiceEntry("[","]","New Game") },
                {ConsoleKey.DownArrow, new ChoiceEntry("[","]","Load Game") },
                {ConsoleKey.LeftArrow, new ChoiceEntry("[","]","Back") }
            }, true);
            switch (choice)
            {
                case 0:
                    Console.WriteLine("Loading New Game...");
                    break;
                case 1:
                    Console.WriteLine("Loading Saved Game...");
                    break;
                case 2:
                    ScreenManager.GetScreenManager().EnqueueScreen(new MainMenu());
                    ScreenManager.GetScreenManager().RenderNextScreen();
                    break;
            }
        }
    }
}
