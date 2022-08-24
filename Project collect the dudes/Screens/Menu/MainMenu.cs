namespace Collect_Dudes.Screens.Menu
{
    using ConsoleUtilities.Colours;
    using ConsoleUtilities.Inputs;
    using ConsoleUtilities.Screens;
    using System;
    using System.Collections.Generic;
    using Utilities;

    /// <summary>
    /// A main menu.
    /// </summary>
    internal class MainMenu : Screen
    {
        /// <summary>
        /// Render the main menu.
        /// </summary>
        public override void Render()
        {
            byte choice = Inputs.ChoiceDialogue(Colour.AquaFG + "TODO: Create ASCII Heading", TextUtilities.divider, new Dictionary<ConsoleKey, ChoiceEntry>()
            {
                { ConsoleKey.Enter, TextUtilities.BuildChoiceEntry("Play") },
                { ConsoleKey.Escape, TextUtilities.BuildChoiceEntry("Exit") }
            });
            
            switch (choice)
            {
                case 0:
                    ScreenManager.QuickRender(new PlayMenu());
                    
                    break;
                
                case 1:
                    // Exit the application.
                    Environment.Exit(0);
                    
                    break;
                
                default:
                    // Redraw the page.
                    ScreenManager.QuickRender(new MainMenu());
                    
                    break;
            }
        }
    }
}