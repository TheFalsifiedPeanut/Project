namespace Collect_Dudes.Screens.Squad
{
    using ConsoleUtilities.Inputs;
    using ConsoleUtilities.Screens;
    using ConsoleUtilities.Serialisation;
    using Data.General;
    using Data.Units;
    using Menu;
    using Serialization;
    using System;
    using System.Collections.Generic;
    using Utilities;

    /// <summary>
    /// An squad viewer for assessing members of the player owned squads.
    /// </summary>
    class SquadViewer : Screen
    {
        /// <summary>
        /// Render the squad view.
        /// </summary>
        public override void Render()
        {
            Unit[] units = JSONData<Unit[]>.LoadData(InternalSettings.unitDataPath);

            Console.WriteLine("|\tName\t   | Age | STR | AGI | INT |  Morale  |  Happiness  |");
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------");

            byte choiceIndex = 1;
            Dictionary<ConsoleKey, ChoiceEntry> choiceOptions = new Dictionary<ConsoleKey, ChoiceEntry>();

            if (units is not null)
            {
                foreach (Unit unit in units)
                {
                    choiceOptions.Add((ConsoleKey)(choiceIndex + 48), TextUtils.BuildChoiceEntry("|" + TextUtils.Spacing(20, unit.name.Length) + unit.name + "|" + TextUtils.Spacing(5, ((IAge)unit).age.ToString().Length) + ((IAge)unit).age + "|" + TextUtils.Spacing(5, unit.strength.ToString().Length) + unit.strength + "|" + TextUtils.Spacing(5, unit.agility.ToString().Length) + unit.agility + "|" + TextUtils.Spacing(5, unit.intelligence.ToString().Length) + unit.intelligence + "|" + TextUtils.Spacing(10, unit.morale.ToString().Length) + unit.morale + "|" + TextUtils.Spacing(13, unit.happiness.ToString().Length) + unit.happiness + "|"));
                    choiceIndex++;
                }
            }

            choiceOptions.Add(ConsoleKey.Backspace, TextUtils.BuildChoiceEntry("Back"));

            byte choice = Inputs.ChoiceDialogue(string.Empty, TextUtils.divider, choiceOptions);

            if (choice == choiceIndex)
            {
                ScreenManager.QuickRender(new Overworld());
            }
            else
            {
                ScreenManager.QuickRender(new UnitViewer(units[choice]));
            }
        }
    }
}
