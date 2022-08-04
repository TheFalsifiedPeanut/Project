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
    using World.DataPools;

    /// <summary>
    /// An squad viewer for assessing members of the player owned squads.
    /// </summary>
    class SquadViewer : Screen
    {
        /// <summary>
        /// Render the squad viewer.
        /// </summary>
        public override void Render()
        {
            // TODO: Replace with the squad from the agency currently being viewed.
            Unit[] units = JSONData<Unit[]>.LoadData(InternalSettings.unitDataPath);
            units = UnitPool.GetData().ToArray();

            Console.WriteLine("| Index |\tName\t   | Age | STR | AGI | INT |  Morale  |  Happiness  |");
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------");

            byte choiceIndex = 0;
            Dictionary<ConsoleKey, ChoiceEntry> choiceOptions = new Dictionary<ConsoleKey, ChoiceEntry>();

            if (units is not null)
            {
                // TODO: Convert this system to use a page system to work with overflow of units to number keys.
                for (int i = 0; i < 10; i++)
                {
                    if (i >= units.Length)
                    {
                        break;
                    }

                    Unit unit = units[i];
                    
                    // We add 48 to get the number key as '1' is key 48.
                    choiceOptions.Add((ConsoleKey) (choiceIndex + 48), TextUtilities.BuildChoiceEntry("   |" + TextUtilities.Spacing(18, unit.name.Length) + unit.name + "|" + TextUtilities.Spacing(5, ((IAge) unit).age.ToString().Length) + ((IAge) unit).age + "|" + TextUtilities.Spacing(5, unit.strength.ToString().Length) + unit.strength + "|" + TextUtilities.Spacing(5, unit.agility.ToString().Length) + unit.agility + "|" + TextUtilities.Spacing(5, unit.intelligence.ToString().Length) + unit.intelligence + "|" + TextUtilities.Spacing(10, unit.morale.ToString().Length) + unit.morale + "|" + TextUtilities.Spacing(13, unit.happiness.ToString().Length) + unit.happiness + "|"));
                    
                    choiceIndex++;
                }
            }

            choiceOptions.Add(ConsoleKey.Backspace, TextUtilities.BuildChoiceEntry("Back"));

            byte choice = Inputs.ChoiceDialogue(string.Empty, TextUtilities.divider, choiceOptions);

            if (choice == choiceIndex)
            {
                ScreenManager.QuickRender(new Overworld());
            }
            
            else if (choice < choiceIndex)
            {
                ScreenManager.QuickRender(new UnitViewer(units?[choice]));
            }

            else
            {
                // Redraw the page.
                ScreenManager.QuickRender(new SquadViewer());
            }
        }
    }
}
