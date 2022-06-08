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
    using System.Text;

    class SquadViewer : Screen
    {
        public override void Render()
        {
            Unit[] units = JSONData<Unit[]>.LoadData(InternalSettings.UnitsPath);
            Console.WriteLine("\tName\t    | Age | STR | AGI | INT |  Morale  |  Happiness  "); 
            foreach (Unit unit in units)
            {
                Console.WriteLine(Spacing(20, unit.name.Length) + unit.name + "|" + Spacing(5, ((IAge)unit).age).ToString().Length) + (((IAge)unit).age.ToString().Length)) + "|" + unit.strength + "|" + unit.agility + " | " + unit.willPower + " | " + unit.morale + " | " + unit.happiness);                       
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
        string Spacing(int expectedSize, int dataSize)
        {
            StringBuilder spaceString = new StringBuilder();
            for (int i = 0; i < expectedSize - dataSize; i++)
            {
                spaceString.Append(" ");
            }
            return spaceString.ToString();
        }
    }
}
