namespace Collect_Dudes.Screens.Menu
{
    using System;
    using System.Collections.Generic;
    using Utilities;
    using ConsoleUtilities.Colours;
    using ConsoleUtilities.Inputs;
    using ConsoleUtilities.Screens;

    /// <summary>
    /// A main menu.
    /// </summary>
    internal class MainMenu : Screen
    {
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
