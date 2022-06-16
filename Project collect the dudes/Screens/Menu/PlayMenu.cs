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
            byte choice = Inputs.ChoiceDialogue(string.Empty, TextUtilities.divider, new Dictionary<ConsoleKey, ChoiceEntry>()
            {
                {ConsoleKey.N, TextUtilities.BuildChoiceEntry("New Game") },
                {ConsoleKey.L, TextUtilities.BuildChoiceEntry("Load Game") },
                {ConsoleKey.Backspace, TextUtilities.BuildChoiceEntry("Back") }
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
                
                default:
                    // Redraw the page.
                    ScreenManager.QuickRender(new PlayMenu());
                    
                    break;
            }
        }
    }
}
