using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Collect_Dudes.Utilities;
using ConsoleUtilities.Colours;
using ConsoleUtilities.Inputs;
using ConsoleUtilities.Screens;
using Collect_Dudes.Screens.Menu.Enums;
using Collect_Dudes.Data.Groups;
using Collect_Dudes.Data.Units.Enums;
using Collect_Dudes.World.DataPools;
using Collect_Dudes.Data.Player;
using Collect_Dudes.World.Generators;
using Collect_Dudes.Data.Units;

namespace Collect_Dudes.Screens.Menu
{
    internal class SquadCreator : Screen
    {
        SquadCreationState squadCreationState;
        string squadName;
        string mainColour;
        string secondaryColour;
        string altMainColour;
        string altSecondaryColour;
        ConsoleKey[] choiceKeys;
        string[] colours;

        public override void Render()
        {
            
            string choiceDialogue = "This wasn't supposed to happen.";
            Dictionary<ConsoleKey, ChoiceEntry> choiceEntries = new Dictionary<ConsoleKey, ChoiceEntry>();


            switch (squadCreationState)
            {
                case SquadCreationState.NAME:
                    choiceDialogue = "Please enter SQUAD NAME: ";
                    break;
                case SquadCreationState.MAIN:
                    choiceDialogue = "Please choose your squad's PRIMARY COLOUR: ";
                    for (int i = 0; i < colours.Length; i++)
                    {
                        choiceEntries.Add(choiceKeys[i], TextUtilities.BuildChoiceEntry(colours[i]));
                    }
                    break;
                case SquadCreationState.SECONDARY:
                    choiceDialogue = "Please choose your squad's SECONDARY COLOUR: ";
                    for(int i = 0; i < colours.Length; i++)
                    {
                        choiceEntries.Add(choiceKeys[i], TextUtilities.BuildChoiceEntry(colours[i]));
                    }
                    break;
                case SquadCreationState.ALTMAIN:
                    choiceDialogue = "Please choose your squad's ALTERNATE MAIN COLOUR: ";
                    int choiceKeyIndex = 0;
                    for(int i = 0; i < colours.Length; i++)
                    {
                        if (colours[i] != mainColour)
                        {
                            choiceEntries.Add(choiceKeys[choiceKeyIndex], TextUtilities.BuildChoiceEntry(colours[i]));
                            choiceKeyIndex++;
                        }  
                    }
                    break;
                case SquadCreationState.ALTSECONDARY:
                    choiceDialogue = "Please choose your squad's ALTERNATE SECONDARY COLOUR: ";
                    int altChoiceKeyIndex = 0;
                    for (int i = 0; i < colours.Length; i++)
                    {
                        if (colours[i] != mainColour)
                        {
                            choiceEntries.Add(choiceKeys[altChoiceKeyIndex], TextUtilities.BuildChoiceEntry(colours[i]));
                            altChoiceKeyIndex++;
                        }
                    }
                    break;

            }



            if (squadCreationState == SquadCreationState.NAME)
            {
                Console.WriteLine(choiceDialogue);
                squadName = Console.ReadLine();
            }
            
            else
            {
                //choiceEntries.Add(ConsoleKey.Backspace, TextUtilities.BuildChoiceEntry("Back"));
                int choice = Inputs.ChoiceDialogue(choiceDialogue, TextUtilities.divider, choiceEntries);
                if (choice < 0 || choice >= colours.Length)
                {
                    ScreenManager.QuickRender(this);
                }

                switch (squadCreationState)
                {
                    case SquadCreationState.MAIN:
                        
                        mainColour = colours[choice];
                        break;

                    case SquadCreationState.ALTMAIN:
                        int mainColourIndex = colours.ToList().IndexOf(mainColour);
                        altMainColour = colours[choice < mainColourIndex ? choice : choice + 1];
                        break;

                    case SquadCreationState.SECONDARY:
                        secondaryColour = colours[choice];

                        break;
                    case SquadCreationState.ALTSECONDARY:
                        int secondaryColourIndex = colours.ToList().IndexOf(secondaryColour);
                        altSecondaryColour = colours[choice < secondaryColourIndex ? choice : choice + 1];
                        break;
                }
            }
            squadCreationState++;
            
            if (squadCreationState == SquadCreationState.FINISHED)
            {
                
                Collect_Dudes.Data.Groups.Squad playerSquad = new Collect_Dudes.Data.Groups.Squad((byte)StarLevel.ONE, new HashSet<ushort>(), mainColour, secondaryColour, altMainColour, altSecondaryColour);

                for (int i = 0; i < 6; i++)
                {
                    Unit unit = UnitGenerator.GenerateUnit(UnitPool.FindFirstFreeID(), StarLevel.ONE);
                    UnitPool.AddUnit(unit);
                    playerSquad.AddUnit(unit);
                }

                ushort agencyID = AgencyPool.FindFirstFreeID();
                AgencyPool.AddAgency(new Agency(agencyID, squadName, (byte)StarLevel.ONE, 100, playerSquad));
                PlayerManager.GetPlayerManager().player = new Player("Joe", new World.Date(0,0,0), agencyID);
                ScreenManager.QuickRender(new Overworld());
            }
            else
            {
                ScreenManager.QuickRender(this);
            }
            
        }
        public SquadCreator()
        {
            choiceKeys = new ConsoleKey[6] {ConsoleKey.D1, ConsoleKey.D2, ConsoleKey.D3, ConsoleKey.D4 ,ConsoleKey.D5, ConsoleKey.D6};
            colours = new string[6] { "Black", "White", "Red", "Blue", "Yellow", "Green" };
        }

        
    }
}
