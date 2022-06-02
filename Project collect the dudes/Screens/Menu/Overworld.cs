using ConsoleUtilities.Screens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleUtilities.Inputs;
using Collect_Dudes.Utilities;
using Collect_Dudes.Screens.Squad;

namespace Collect_Dudes.Screens.Menu
{
    class Overworld : Screen
    {

        public override void Render()
        {
            byte choice = Inputs.ChoiceDialogue("This is a choice.", TextUtils.divider, new Dictionary<ConsoleKey, ChoiceEntry> 
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
