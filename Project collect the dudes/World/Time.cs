namespace Collect_Dudes.World
{
    using System;

    /// <summary>
    /// Tracks time and date of the in game world.
    /// </summary>
    internal class Time
    {
        #region Fields

        #region Static Fields

        /// <summary>
        /// A static reference to time.
        /// </summary>
        static Time time;

        #endregion

        /// <summary>
        /// The current date in time.
        /// </summary>
        Date currentDate;

        #endregion

        #region Getters

        /// <summary>
        /// Get the current date.
        /// </summary>
        /// <returns> Returns the current date. </returns>
        public static Date GetDate()
        {
            return time.currentDate;
        }

        #endregion

        #region Initialisation

        /// <summary>
        /// A constructor for Time.
        /// </summary>
        /// <param name="startDay"> The start day of time. </param>
        /// <param name="startMonth"> The start month of time. </param>
        /// <param name="startYear"> The start year of time. </param>
        public Time(byte startDay, byte startMonth, ushort startYear)
        {
            if (time is null)
            {
                time = this;
            }
            
            Console.WriteLine(time);
            
            currentDate = new Date(startDay, startMonth, startYear);
        }

        #endregion

        #region Calculations

        /// <summary>
        /// Get the number of years that have passed since the specified initial date.
        /// </summary>
        /// <param name="initialDay"> The initial day of the starting point. </param>
        /// <param name="initialMonth"> The initial month of the starting point. </param>
        /// <param name="initialYear"> The initial year of the starting point. </param>
        /// <returns> Returns the number of years that have passed since the specified initial date. </returns>
        public static ushort GetYearsSince(byte initialDay, byte initialMonth, ushort initialYear)
        {
            return (ushort)(time.currentDate.GetYear() - (initialYear + (time.currentDate.GetMonth() - (initialMonth + (time.currentDate.GetDay() - initialDay <= 0 ? 1 : 0) <= 0 ? 1 : 0))));
        }
        
        /// <summary>
        /// Get the number of years that have passed since the specified initial date.
        /// </summary>
        /// <param name="initialDate"> The initial date as the starting point. </param>
        /// <returns> Returns the number of years that have passed since the specified initial date. </returns>
        public static ushort GetYearsSince(Date initialDate)
        {
            //return 1;
            Console.WriteLine(time);
            Console.WriteLine(time.currentDate);
            return (ushort)(time.currentDate.GetYear() - (initialDate.GetYear() + (time.currentDate.GetMonth() - (initialDate.GetMonth() + (time.currentDate.GetDay() - initialDate.GetDay() <= 0 ? 1 : 0) <= 0 ? 1 : 0))));
        }

        #endregion

        #region Behaviours

        /// <summary>
        /// Increments the day by one day.
        /// </summary>
        public static void IncrementDay()
        {
            time.currentDate.IncrementDay();
        }

        #endregion
    }
}