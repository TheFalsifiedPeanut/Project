namespace Collect_Dudes.Screens.Squad
{
    using ConsoleUtilities.Inputs;
    using ConsoleUtilities.Screens;
    using Data.General;
    using Data.Units;
    using System;
    using System.Collections.Generic;
    using Utilities;

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
            Console.WriteLine(unit.name + "\n-General Information-\nDate of Birth: " + unit.birthday.GetDay() + "/" + unit.birthday.GetMonth() + "/" + unit.birthday.GetYear() + "\nAge: " + ((IAge)unit).age + "\n\n");
            Console.WriteLine("-Attributes-\nStrength: " + unit.strength + "\nAgility: " + unit.agility + "\nIntelligence: " + unit.intelligence + "\n");
            Console.WriteLine("-Statistics-\nHealth: " + unit.maximumHealth + "\nHealth Regeneration: " + unit.healthRegeneration + "\nMana: " + unit.maximumMana + "\nMana Regeneration: " + unit.manaRegeneration + "\nStamina: " + unit.maximumStamina + "\nStamina Regeneration: " + unit.staminaRegeneration + "\nSpeed: " + unit.speed + "\nPhysical Resistance: " + unit.physicalResistance + "\nMagical Resistance: " + unit.magicalResistance + "\nHit Chance: " + unit.hitChance + "\nDodge Chance: " + unit.dodgeChance + "\nPhysical Damage: " + unit.basePhysicalDamage + "\nCritical Chance: " + unit.physicalCriticalChance + "\n");
            Console.WriteLine("-Mental Statistics-\nLeadership: " + unit.leadership + "\nTeamwork: " + unit.teamwork + "\nMorale: " + unit.morale + "\nHappiness: " + unit.happiness + "\nMentalTraits: " + unit.mentalTraits + "\n");
            Console.WriteLine("-Employment-\nWage: " + unit.wage + "\nTerm Remaining: " + unit.termRemaining + "\nTeamID: " + unit.teamID + "\n");

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