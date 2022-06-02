using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Collect_Dudes.Data.Information;
using Collect_Dudes.Data.Mentals;

namespace Collect_Dudes.Data.Units
{
    internal class Unit : IAge
    {

        public Unit(string name, int day, int month, int year, byte strength, byte agility, byte willPower, Morale morale, Happiness happiness)
        {
            this.name = name;
            this.day = day;
            this.month = month;
            this.year = year;
            this.strength = strength;
            this.agility = agility;
            this.willPower = willPower;
            this.morale = morale;
            this.happiness = happiness;

        }

        #region General
        public string name { get; set; }
        public int day { get; set; }
        public int month { get; set; }
        public int year { get; set; }
        #endregion

        #region Attributes
        public byte strength { get; set; }
        public byte agility { get; set; }
        public byte willPower { get; set; }
        #endregion

        #region Statistics
        float health;
        float mana;
        float stamina;
        byte speed;
        float physicalResistance;
        float magicResistance;
        float hitChance;
        float dodgeChance;
        float physicalDamage;
        float physicalCritChance;
        float physicalHitMultiplier;
        #endregion

        #region Mental Statistics
        public Morale morale { get; set; }
        public Happiness happiness { get; set; }
        public MentalTraits mentalTraits { get; set; }
        public byte leadership { get; set; }
        public byte teamwork { get; set; }
        #endregion

        #region MyRegion

        #endregion

        #region Employment
        int wage;
        ushort teamID;
        int termRemaining;

        #endregion
    }
}
