namespace Collect_Dudes.Screens.Squad
{
    using Collect_Dudes.Data.General;
    using Collect_Dudes.Data.Units;
    using Collect_Dudes.Utilities;
    using ConsoleUtilities.Inputs;
    using ConsoleUtilities.Screens;
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// View them stats
    /// </summary>
    internal class UnitViewer : Screen
    {
        #region Fields

        #region Read Only Fields
        
        /// <summary>
        /// The unit to be viewed.
        /// </summary>
        readonly Unit unit;

        #endregion

        #endregion
        
        /// <summary>
        /// Render the unit viewer.
        /// </summary>
        public override void Render()
        {
            Console.WriteLine(unit.name + "\nGeneral Information--\n Date of Birth: " + unit.birthday.GetDay() + "/" + unit.birthday.GetMonth() + "/" + unit.birthday.GetYear() + "\n Age: " + ((IAge)unit).age + "\n\n");
            Console.WriteLine("Attributes--\n Strength: " + unit.strength + "\n Agility: " + unit.agility + "\n Intelligence: " + unit.intelligence + "\n");
            Console.WriteLine("Statistics--\n Health: " + unit.maximumHealth + "\n Mana: " + unit.maximumStamina + "\n Stamina: " + unit.maximumStamina + "\n Speed: " + unit.speed + "\n Physical Resistance: " + unit.physicalResistance + "\n Magic Resistance: " + unit.magicResistance + "\n Hit Chance: " + unit.hitChance + "\n Dodge Chance: " + unit.dodgeChance + "\n Physical Damage: " + unit.basePhysicalDamage + "\n Crit Chance: " + unit.physicalCriticalChance + "\n");
            Console.WriteLine("Mental Statistics--\n Morale: " + unit.morale + "\n Happiness: " + unit.happiness + "\n MentalTraits: " + unit.mentalTraits + "\n Leadership: " + unit.leadership + "\n Teamwork: " + unit.teamwork + "\n");
            Console.WriteLine("Employment-- \n Wage: " + unit.wage + "\n TeamID: " + unit.teamID + "\n Term Remaining: " + unit.termRemaining + "\n");

            byte choice = Inputs.ChoiceDialogue(string.Empty, TextUtilities.divider, new Dictionary<ConsoleKey, ChoiceEntry>()
            {
                {ConsoleKey.Backspace, TextUtilities.BuildChoiceEntry("Back") }
            });

            if (choice is 0)
            {
                ScreenManager.QuickRender(new SquadViewer());
            }

            else
            {
                // Redraw the page.
                ScreenManager.QuickRender(new UnitViewer(unit));
            }
        }

        #region Initialisation

        /// <summary>
        /// A constructor for the UnitViewer.
        /// </summary>
        /// <param name="unit"> The unit to be viewed. </param>
        public UnitViewer(Unit unit)
        {
            this.unit = unit;
        }

        #endregion
    }
}























































/*// "Um... I don't even know where to start with you. I mean, do you even know who you're talkin' to?

Scout: D - Do you have any idea, any idea who I am?"

Scout: "Basically - kind of a big deal!"


Scout: [flexes a scrawny arm] "Oh man, that's beautiful. Heh!"

Scout: " Ya' listenin'? OK. Grass grows, birds fly, sun shines, and brotha'- [pokes the camera] I hurt people."

Scout: "BOINK!"

Scout: [back to text] "I'm a force a' nature!"

Scout: "BONK!"

Scout: "If you were from where I was from, you'd be f**kin' dead!"

Scout: "WOOO!"*/