

namespace Collect_Dudes.Screens.Menu
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Utilities;
    using ConsoleUtilities.Inputs;
    using ConsoleUtilities.Colour;
    using ConsoleUtilities.Screens;

    class MainMenu : Screen
    {
        public override void Render()
        {
            byte choice = Inputs.ChoiceDialogue("CHOOSE", "-Ominous-", new Dictionary<ConsoleKey, ChoiceEntry>()
            {
                { ConsoleKey.Enter , new ChoiceEntry("[","]","Play")},
                { ConsoleKey.Escape , new ChoiceEntry("[","]","Exit")}
               }, true);
            switch (choice)
            {
                case 0:
                    ScreenManager.QuickRender(new PlayMenu());
                    break;
                case 1:
                    Environment.Exit(0);
                    break;
            }
            Console.WriteLine(choice);
            
        }
    }
}
