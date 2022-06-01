using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Collect_Dudes.Data.Information;
using Collect_Dudes.Data.Mentals;

namespace Collect_Dudes.Data.Units
{
    class Unit : IAge
    {
        #region General
        string name;
        public int day { get; set; }
        public int month { get; set; }
        public int year { get; set; }
        #endregion

        #region Attributes
        byte strength;
        byte agility;
        byte willPower;
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
        Morale morale;
        Happiness happiness;
        byte leadership;
        byte teamwork;
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
