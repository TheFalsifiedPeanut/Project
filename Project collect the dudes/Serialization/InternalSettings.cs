namespace Collect_Dudes.Serialization
{
    /// <summary>
    /// Settings used internally by the game.
    /// </summary>
    internal class InternalSettings
    {
        #region Paths
        
        /// <summary>
        /// The path to the units file.
        /// </summary>
        public static string unitDataPath => "Test\\units.json";

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
    }
}
