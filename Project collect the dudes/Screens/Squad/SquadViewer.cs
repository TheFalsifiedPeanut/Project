namespace Collect_Dudes.Screens.Squad
{
    using System;
    using System.Collections.Generic;
    using Data.Units;
    using Serialization;
    using Utilities;
    using ConsoleUtilities.Inputs;
    using ConsoleUtilities.Screens;
    using ConsoleUtilities.Serialisation;
    using Data.Information;

    class SquadViewer : Screen
    {
        public override void Render()
        {
            Unit[] units = JSONData<Unit[]>.LoadData(InternalSettings.UnitsPath);
            foreach (Unit unit in units)
            {
                Console.WriteLine(unit.name + " | " + ((IAge)unit).age + " | " + unit.strength + " | " + unit.agility + " | " + unit.willPower + " | " + unit.morale + " | " + unit.happiness);                       
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
