using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Collect_Dudes.Data.Units;
using Collect_Dudes.Serialization;
using Collect_Dudes.Utilities;
using ConsoleUtilities.Inputs;
using ConsoleUtilities.Screens;
using ConsoleUtilities.Serialisation;

namespace Collect_Dudes.Screens.Squad
{
    class SquadViewer : Screen
    {
        public override void Render()
        {
            Unit[] units = JSONData<Unit[]>.LoadData(InternalSettings.UnitsPath);
            foreach (Unit unit in units)
            {
                Console.WriteLine(unit.name + " | " + unit.year + " | " + unit.strength + " | " + unit.agility + " | " + unit.willPower + " | " + unit.morale + " | " + unit.happiness);                       
            }
            byte choice = Inputs.ChoiceDialogue("This is a choice?", TextUtils.divider, new Dictionary<ConsoleKey, ChoiceEntry>
            {
                { ConsoleKey.S, TextUtils.BuildChoiceEntry("Squad Viewer")}
            });
            switch (choice)
            {
                case 0:

                    break;
            }
        }
    }
}
