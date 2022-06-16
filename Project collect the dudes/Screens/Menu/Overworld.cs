namespace Collect_Dudes.Screens.Menu
{
    using ConsoleUtilities.Inputs;
    using ConsoleUtilities.Screens;
    using Squad;
    using System;
    using System.Collections.Generic;
    using Utilities;
    
    /// <summary>
    /// An Overworld for choosing a which management aspect to pursue.
    /// </summary>
    class Overworld : Screen
    {
        /// <summary>
        /// Render the Overworld.
        /// </summary>
        public override void Render()
        {
            byte choice = Inputs.ChoiceDialogue("Select a screen to view.", TextUtilities.divider, new Dictionary<ConsoleKey, ChoiceEntry> 
            {
                { ConsoleKey.S, TextUtilities.BuildChoiceEntry("Squad Viewer")}
            });

            if (choice is 0)
            {
                ScreenManager.QuickRender(new SquadViewer());
            }

            else
            {
                // Redraw the page.
                ScreenManager.QuickRender(new Overworld());
            }
        }
    }
}
