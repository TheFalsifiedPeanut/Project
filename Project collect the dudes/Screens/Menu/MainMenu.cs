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
            byte choice = Inputs.ChoiceDialogue(Colour.AquaFG + "TODO: Create ASCII Heading", TextUtils.divider, new Dictionary<ConsoleKey, ChoiceEntry>()
            {
                { ConsoleKey.Enter, TextUtils.BuildChoiceEntry("Play") },
                { ConsoleKey.Escape, TextUtils.BuildChoiceEntry("Exit") }
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
        }
    }
}
