﻿namespace Collect_Dudes.Serialization
{
    /// <summary>
    /// Settings used internally by the game.
    /// </summary>
    internal static class InternalSettings
    {


        #region Paths
        
        /// <summary>
        /// The path to the units file.
        /// </summary>
        public static string unitDataPath => "units.json";

        #endregion

        #region Time

        /// <summary>
        /// The number of days in a month.
        /// </summary>
        public static byte daysInMonth => 28;

        /// <summary>
        /// The number of months in a year.
        /// </summary>
        public static byte monthsInYear => 12;

        #endregion
        #region Generators
        #region Units
        public static byte baseAttributeValue => 1;
        public static byte capacityAttributeValue => 20;
        public static byte baseAttributePoints => 5;
        public static byte oneStarAttributePointsMaximum => 10;
        public static byte twoStarAttributePointsMaximum => 20;
        public static byte threeStarAttributePointsMaximum => 35;
        public static byte fourStarAttributePointsMaximum => 45;
        public static byte fiveStarAttributePointsMaximum => 55;

        public static float healthPerStrength => 10;
        public static float healthRegenPerStrength => 0.1f;
        public static float manaPerIntelligence => 10;

        public static float manaRegenPerIntelligence => 0.5f;
        public static float staminaPerAgility => 10;
        public static float staminaRegenPerAgility  => 1;
        public static byte speedPerAgility => 1;
        public static float physicalResitancePerStrength => 2;
        public static float magicResistancePerIntelligence => 2;
        public static float hitChancePerAgility => 2.5f;
        public static float dodgeChancePerAgility => 1.5f;
        public static float basePhysicalDamagePerStrength => 1;
        public static float physicalCritChancePerAgility => 1;

        public static float baseLeadershipValue => 1;
        public static float capacityLeadershipValue => 20;
        public static float baseTeamworkValue => 1;
        public static float capacityTeamworkValue => 20;

        
        #endregion
        #endregion
    }
}
