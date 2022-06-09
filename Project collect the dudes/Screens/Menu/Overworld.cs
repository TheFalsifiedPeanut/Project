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
            byte choice = Inputs.ChoiceDialogue("Select a screen to view.", TextUtils.divider, new Dictionary<ConsoleKey, ChoiceEntry> 
            {
                { ConsoleKey.S, TextUtils.BuildChoiceEntry("Squad Viewer")}
            }, true);
            
            switch (choice)
            {
                case 0:
                    ScreenManager.QuickRender(new SquadViewer());
                    
                    break;
            }
        }
    }
}
