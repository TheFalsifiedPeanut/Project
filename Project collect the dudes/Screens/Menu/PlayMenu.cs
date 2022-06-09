namespace Collect_Dudes.Screens.Menu
{
    using ConsoleUtilities.Inputs;
    using ConsoleUtilities.Screens;
    using System;
    using System.Collections.Generic;
    using Utilities;

    /// <summary>
    /// A play menu for choosing a new game or saved game.
    /// </summary>
    internal class PlayMenu : Screen
    {
        /// <summary>
        /// Render the play menu.
        /// </summary>
        public override void Render()
        {
            byte choice = Inputs.ChoiceDialogue(string.Empty, TextUtils.divider, new Dictionary<ConsoleKey, ChoiceEntry>()
            {
                {ConsoleKey.N, TextUtils.BuildChoiceEntry("New Game") },
                {ConsoleKey.L, TextUtils.BuildChoiceEntry("Load Game") },
                {ConsoleKey.Backspace, TextUtils.BuildChoiceEntry("Back") }
            }, true);
            
            switch (choice)
            {
                case 0:
                    ScreenManager.QuickRender(new Overworld());

                    break;
                
                case 1:
                    Console.WriteLine("Loading Saved Game...");
                    
                    break;
                
                case 2:
                    ScreenManager.QuickRender(new MainMenu());
                    
                    break;
            }
        }
    }
}
